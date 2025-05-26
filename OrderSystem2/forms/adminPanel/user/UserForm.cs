
using OrderSystem2.forms.adminPanel.user;
using OrderSystem2.entity;
using OrderSystem2.dto;


namespace OrderSystem2.forms.user
{
    public partial class UserForm : BaseForm
    {
        private UserRepository repository;

        public UserForm()
        {
            InitializeComponent();

            repository = new UserRepository();

            LoadData();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();
            dataGridUsers.CellDoubleClick += dataGridUsers_CellDoubleClick;
        }

        public void LoadData()
        {
            var users = repository.GetUserDto();

            dataGridUsers.AutoGenerateColumns = false;
            dataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsers.Columns.Clear();


            dataGridUsers.Columns.Add("Id", "Kullanıcı No");
            dataGridUsers.Columns["Id"].DataPropertyName = "Id";

            dataGridUsers.Columns.Add("Name", "Ad");
            dataGridUsers.Columns["Name"].DataPropertyName = "Name";

            dataGridUsers.Columns.Add("Surname", "Soyad");
            dataGridUsers.Columns["Surname"].DataPropertyName = "Surname";

            dataGridUsers.Columns.Add("RoleName", "Yetki");
            dataGridUsers.Columns["RoleName"].DataPropertyName = "RoleName";

            dataGridUsers.Columns.Add("Email", "Email");
            dataGridUsers.Columns["Email"].DataPropertyName = "Email";

            dataGridUsers.DataSource = users;
            dataGridUsers.ReadOnly = true;
        }

        private void dataGridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UserDto selectedUser = (UserDto)dataGridUsers.Rows[e.RowIndex].DataBoundItem;
                User selected = repository.GetById(selectedUser.Id);
                UserDetailForm detailForm = new UserDetailForm(selected);
                detailForm.Show();
            }
        }

        private void labelAddFarmer_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
    }
}
