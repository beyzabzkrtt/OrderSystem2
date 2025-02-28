using OrderSystem2.forms.farmer;
using OrderSystem2.forms.product;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class FarmerDetail : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private ZoneRepository _zoneRepository;
        private ZoneService _zoneService;

        private Farmer _farmer;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public FarmerDetail(Farmer farmer)
        {
            InitializeComponent();
            _farmer = farmer;

            _farmerRepository = new FarmerRepository(_connectionString);
            _farmerService = new FarmerService(_farmerRepository);

            _zoneRepository = new ZoneRepository(_connectionString);
            _zoneService = new ZoneService(_zoneRepository);
         
            LoadData();
            Bind();

        }

        private void LoadData()
        {
            textBoxFarmerID.Text = _farmer.Id.ToString();
            textBoxFarmerID.ReadOnly = true;
            textBoxZoneId.Text = _zoneService.GetZoneNameByFarmerId(_farmer.Id);
            textBoxZoneId.ReadOnly = true;
            textBoxName.Text = _farmer.Name;
            textBoxSurname.Text = _farmer.Surname;
            textBoxPhone.Text = _farmer.Phone;
            textBoxEmail.Text = _farmer.Email;
            textBoxAddress.Text = _farmer.Address;
            textBoxTc.Text = _farmer.Tc;
            textBoxCreatedBy.Text = _farmer.CreatedBy.ToString();
            textBoxCreatedBy.ReadOnly = true;
            textBoxCreatedAt.Text = _farmer.CreatedAt.ToString();
            textBoxCreatedAt.ReadOnly = true;
            textBoxUpdatedBy.Text = _farmer.UpdatedBy.ToString();
            textBoxUpdatedBy.ReadOnly = true;
            textBoxupdatedAt.Text = _farmer.UpdatedAt.ToString();
            textBoxUpdatedBy.ReadOnly = true;
        }

        private void Bind()
        {
            this.MouseDown += new MouseEventHandler(MouseDownHandler);
            this.MouseMove += new MouseEventHandler(MouseMoveHandler);
            this.MouseUp += new MouseEventHandler(MouseUpHandler);


            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseDown += new MouseEventHandler(MouseDownHandler);
                ctrl.MouseMove += new MouseEventHandler(MouseMoveHandler);
                ctrl.MouseUp += new MouseEventHandler(MouseUpHandler);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                _farmer.Name = textBoxName.Text;
                _farmer.Surname = textBoxSurname.Text;
                _farmer.Tc = textBoxTc.Text;
                _farmer.Phone = textBoxPhone.Text;
                _farmer.Email = textBoxEmail.Text;
                _farmer.Address = textBoxAddress.Text;

                _farmerService.Update(_farmer, _farmer.Id);

                MessageBox.Show("Güncelleme başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

                FarmerForm farmerForm = Application.OpenForms.OfType<FarmerForm>().FirstOrDefault();
                if (farmerForm != null)
                {
                    farmerForm.LoadFarmer();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?",
                                        "Onay",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _farmerService.Delete(_farmer.Id);

                    MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowField_Click(object sender, EventArgs e)
        {
            FarmerFieldForm farmerFieldForm = new FarmerFieldForm(_farmer.Id);
            farmerFieldForm.Show();
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            FarmerOrderForm farmerOrderForm = new FarmerOrderForm(_farmer.Id);
            farmerOrderForm.Show();
        }

        private void pictureBoxTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                prevBounds = this.Bounds;

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                pictureBoxExpand.Image = Image.FromFile("C:\\Users\\beboz\\source\\repos\\OrderSystem2\\OrderSystem2\\Resources\\contract.png");
                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Bounds = prevBounds;

                pictureBoxExpand.Image = Image.FromFile("C:\\Users\\beboz\\source\\repos\\OrderSystem2\\OrderSystem2\\Resources\\expand.png");
                isFullScreen = false;
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
