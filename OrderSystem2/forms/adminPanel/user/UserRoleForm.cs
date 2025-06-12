
using OrderSystem2.forms.adminPanel.role;
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.adminPanel.user
{
    public partial class UserRoleForm : AddBaseForm
    {
        public User _user;

        private UserRepository _userRepository;
        private UserService _userService;

        private UserRoleRepository _userRoleRepository;
        private UserRoleService _userRoleService;
        public UserRoleForm(User user)
        {

            InitializeComponent();
            _user = user;

            AttachPanelDragEvents(panel1);
            panel1.SendToBack();

            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);

            _userRoleRepository = new UserRoleRepository();
            _userRoleService = new UserRoleService(_userRoleRepository);

            LoadData(_user);

        }

        public void LoadData(User user)
        {
            textBoxRole.Text = _userService.GetRole(user.Id);         
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm(_user);
            addRoleForm.ShowDialog();
            this.Close();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Yetkiyi kaldırmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _userRoleService.Delete(_user.Id);
                    MessageBox.Show("Yetki kaldırıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    LoadData(_user);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
