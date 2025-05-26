
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.adminPanel.role
{
    public partial class AddRoleForm : AddBaseForm
    {
        private ZoneRepository zoneRepository;
        private ZoneService zoneService;

        private RoleTypeRepository roleTypeRepository;
        private RoleTypeService roleTypeService;

        User _user;
        public AddRoleForm(User user)
        {
            _user = user;

            zoneRepository = new ZoneRepository();
            zoneService = new ZoneService(zoneRepository);

            roleTypeRepository = new RoleTypeRepository();
            roleTypeService = new RoleTypeService(roleTypeRepository);

            InitializeComponent();
            LoadData();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();
        }

        public void LoadData()
        {
            var zones = zoneService.GetAll();
            comboBoxZone.DataSource = zones;
            comboBoxZone.DisplayMember = "Name";
            comboBoxZone.ValueMember = "Id";

            comboBoxZone.SelectedIndexChanged += ComboBoxZone_SelectedIndexChanged;

           
        }

        private void ComboBoxZone_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var roles = roleTypeService.GetAll();
            comboBoxRole.DataSource = roles;
            comboBoxRole.DisplayMember = "Name";
            comboBoxRole.ValueMember = "Id";

            comboBoxRole.SelectedIndexChanged += ComboBoxRole_SelectedIndexChanged;
        }

        private void ComboBoxRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //textBoxRole.Text = $"{}";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
