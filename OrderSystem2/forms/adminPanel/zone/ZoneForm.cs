
using System.Windows.Forms;
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

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "İşlem";
            btnColumn.Text = "Sil";
            btnColumn.Name = "btnSil";
            btnColumn.UseColumnTextForButtonValue = true;

            dataGridZones.Columns.Add(btnColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridZones.Columns[e.ColumnIndex].Name == "btnSil" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridZones.Rows[e.RowIndex].Cells["Id"].Value); // ID hücresine göre
                var result = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    zoneService.Delete(id);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddZone addZone = new AddZone();
            addZone.ShowDialog();
        }
    }
}
