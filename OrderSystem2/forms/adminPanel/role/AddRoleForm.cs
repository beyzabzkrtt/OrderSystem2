
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

        private UserRoleRepository userRoleRepository;
        private UserRoleService userRoleService;

        private RoleRepository roleRepository;  
        private RoleService roleService;

        User _user;
        Role _role;
        public AddRoleForm(User user)
        {
            _user = user;
            _role = new Role();

            zoneRepository = new ZoneRepository();
            zoneService = new ZoneService(zoneRepository);

            roleTypeRepository = new RoleTypeRepository();
            roleTypeService = new RoleTypeService(roleTypeRepository);

            userRoleRepository = new UserRoleRepository();
            userRoleService = new UserRoleService(userRoleRepository);

            roleRepository = new RoleRepository();
            roleService = new RoleService(roleRepository);

            InitializeComponent();
            LoadData();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();

            buttonSave.Click += buttonSave_Click; 
        }

        public void LoadData()
        {
            var zones = zoneService.GetAll();
            comboBoxZone.DataSource = zones;
            comboBoxZone.DisplayMember = "Name";
            comboBoxZone.ValueMember = "Id";

            var roles = roleTypeService.GetAll();
            comboBoxRole.DataSource = roles;
            comboBoxRole.DisplayMember = "Name";
            comboBoxRole.ValueMember = "Id";

            _role = new Role();

            comboBoxRole.SelectedIndexChanged += ComboBoxRole_SelectedIndexChanged;

        }

        private void ComboBoxRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxZone.SelectedValue == null || comboBoxRole.SelectedValue == null)
                return;

            if (!int.TryParse(comboBoxZone.SelectedValue.ToString(), out int selectedZoneId) ||
                !int.TryParse(comboBoxRole.SelectedValue.ToString(), out int selectedRoleTypeId))
                return;

            _role.ZoneId = selectedZoneId;
            _role.RoleTypeId = selectedRoleTypeId;

            Zone zone = zoneService.GetById(selectedZoneId);
            string zoneName = zone.Name;
            RoleType roleType = roleTypeRepository.GetById(selectedRoleTypeId);
            string roleName = roleType.Name;
            textBoxRole.Text = $"{zoneName}" + $" {roleName}";

            // Role oluşturuluyor
            roleService.AddRole(selectedZoneId, selectedRoleTypeId);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UserRole userRole = new UserRole
            {
                UserId = _user.Id,
                RoleId = _role.Id
            };

            string mess = userRoleService.AssignedRole(userRole);
            MessageBox.Show(mess);
        }
    }
}
