
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.adminPanel.zone
{
    public partial class ZoneForm : BaseForm
    {
        private ZoneRepository zoneRepository;
        private ZoneService zoneService;

        public ZoneForm()
        {
            zoneRepository = new ZoneRepository();
            zoneService = new ZoneService(zoneRepository);

            InitializeComponent();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();
            LoadData();

        }

        public void LoadData()
        {
            var zones = zoneService.GetAll();

            dataGridZones.AutoGenerateColumns = false;
            dataGridZones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridZones.Columns.Clear();


            dataGridZones.Columns.Add("Id", "Bölge No");
            dataGridZones.Columns["Id"].DataPropertyName = "Id";

            dataGridZones.Columns.Add("Name", "Ad");
            dataGridZones.Columns["Name"].DataPropertyName = "Name";

            dataGridZones.DataSource = zones;
            dataGridZones.ReadOnly = true;
        }

    }
}
