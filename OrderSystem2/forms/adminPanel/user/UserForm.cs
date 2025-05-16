
namespace OrderSystem2.forms.user
{
    public partial class UserForm : BaseForm
    {
        private UserRepository repository;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public UserForm()
        {
            InitializeComponent();

            repository = new UserRepository();

            LoadData();

            AttachPanelDragEvents(panel1);
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

        private void labelAddFarmer_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
    }
}
