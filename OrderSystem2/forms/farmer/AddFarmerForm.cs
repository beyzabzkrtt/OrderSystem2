using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class AddFarmerForm : Form
    {

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private ZoneRepository _zoneRepository;
        private ZoneService _zoneService;

        private FactoryRepository _factoryRepository;
        private FactoryService _factoryService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public AddFarmerForm()
        {
            InitializeComponent();   

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            _zoneRepository = new ZoneRepository();
            _zoneService = new ZoneService(_zoneRepository);

            _factoryRepository = new FactoryRepository();
            _factoryService = new FactoryService(_factoryRepository);

            pictureBoxClose.Click += pictureBoxClose_Click;

            AttachPanelDragEvents(panel2);
            LoadCombobox();
         
        }
        private void AttachPanelDragEvents(Panel panel)
        {
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = ((Control)sender).PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBoxClose_Click(object? sender, EventArgs e)
        {
           this.Close();
        }

        private void LoadCombobox()
        {
            var factories = _factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";

           
            comboBoxFactory.SelectedIndexChanged += comboBoxFactory_SelectedIndexChanged;

            var zones = _zoneService.GetAll();
            comboBoxZone.DataSource = zones;
            comboBoxZone.DisplayMember = "Name";
            comboBoxZone.ValueMember = "Id";

            comboBoxZone.DataSource = null;
            comboBoxZone.Items.Clear();

        }

        private void comboBoxFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadZones();

            if (comboBoxFactory.SelectedIndex != -1)
            {
                labelPlaceholder.Visible = false;
            }
            else
            {
                labelPlaceholder.Visible = true;
            }
        }

        private void LoadZones()
        {
            if (comboBoxFactory.SelectedValue != null)
            {
                int selectedFactoryId;

                if (comboBoxFactory.SelectedValue is int)
                {
                    selectedFactoryId = (int)comboBoxFactory.SelectedValue;
                }
                else
                {
                    return; 
                }

                var zones = _zoneRepository.GetZoneByFactory(selectedFactoryId);

                comboBoxZone.DataSource = zones;
                comboBoxZone.DisplayMember = "Name";
                comboBoxZone.ValueMember = "Id";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            var farmer = new Farmer();       

            farmer.Name = textBoxName.Text.Trim();
            farmer.Surname = textBoxSurname.Text.Trim();
            farmer.Tc = textBoxTc.Text.Trim();
            farmer.Email = textBoxEmail.Text.Trim();
            farmer.Address = textBoxAddress.Text.Trim();
            farmer.Phone = textBoxPhone.Text.Trim();

            try
            {
                _farmerService.Add(farmer);
                MessageBox.Show("Çiftçi başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FarmerForm farmerForm = Application.OpenForms.OfType<FarmerForm>().FirstOrDefault();
                if (farmerForm != null)
                {
                    farmerForm.LoadFarmer();
                }

                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çiftçi eklenmedi. Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();;
            }
        }


    }
}
