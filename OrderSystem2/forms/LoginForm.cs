using OrderSystem2.service.concretes;

namespace OrderSystem2
{
    public partial class LoginForm : Form
    {

        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private UserRepository _userRepository;
        private UserService _userService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository(_connectionString);
            _userService = new UserService(_userRepository);

           AttachDragEvents(this);
        }

        private void AttachDragEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!(ctrl is TextBox))  // TextBox'ları hariç tut, yoksa yazı yazarken sürüklenir.
                {
                    ctrl.MouseDown += MouseDownHandler;
                    ctrl.MouseMove += MouseMoveHandler;
                    ctrl.MouseUp += MouseUpHandler;
                }

                // Eğer kontrolün içinde başka kontroller varsa, onlara da ekle
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

            if (_userService.ValidateUser(email, password))
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
