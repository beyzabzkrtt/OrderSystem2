using System.Data;
using OrderSystem2.model;
using OrderSystem2.service.concretes;

namespace OrderSystem2
{
    public partial class LoginForm : Form
    {

        private UserRepository _userRepository;
        private UserService _userService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);

           AttachDragEvents(this);
        }

        private void AttachDragEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!(ctrl is TextBox))  
                {
                    ctrl.MouseDown += MouseDownHandler;
                    ctrl.MouseMove += MouseMoveHandler;
                    ctrl.MouseUp += MouseUpHandler;
                }

                if (ctrl.HasChildren)
                {
                    AttachDragEvents(ctrl);
                }
            }
        }

        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        private void MouseUpHandler(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private bool isPasswordHidden = true;

        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtPassword.PasswordChar = '.'; 
            pictureBoxShowHide.Image = Properties.Resources.closed_eye;
        }

        private void pictureBoxShowHide_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                
                txtPassword.PasswordChar = '\0'; 
                pictureBoxShowHide.Image = Properties.Resources.open_eye;
                isPasswordHidden = false;
            }
            else
            {
               
                txtPassword.PasswordChar = '.'; 
                pictureBoxShowHide.Image = Properties.Resources.closed_eye;
                isPasswordHidden = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            bool emailExist = _userRepository.IsEmailExist(email);

            if (!emailExist)
            {
                MessageBox.Show("E-posta kayıtlı değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = _userRepository.GetUserByEmail(email);
                Role rol = _userRepository.GetRoleByUserId(user.Id);

                if (_userService.ValidateUser(email, password))
                {
                    var currentUser = new CurrentUser
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Surname = user.Surname,
                        Email = user.Email,
                        RoleType = rol.RoleTypeEnum,  // enum dönüşümü 
                        Zone = rol.ZoneEnum
                    };

                    MessageBox.Show($"{currentUser.RoleType}");
                    MainForm mainForm = new MainForm(currentUser);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
