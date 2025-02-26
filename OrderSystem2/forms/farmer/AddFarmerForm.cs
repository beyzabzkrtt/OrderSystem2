using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class AddFarmerForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public AddFarmerForm()
        {
            InitializeComponent();   

            _farmerRepository = new FarmerRepository(_connectionString);
            _farmerService = new FarmerService(_farmerRepository);

            pictureBoxClose.Click += pictureBoxClose_Click;

            AttachDragEvents(this);

        }

        private void AttachDragEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!(ctrl is TextBox)) 
                {
                    ctrl.MouseDown += MouseDownHandler;
                    ctrl.MouseMove += MouseMoveHandler;
                    ctrl.MouseUp += MouseUpHandler;
                }

                if (ctrl.HasChildren)
                {
                    AttachDragEvents(ctrl);
                }
            }
            
            parent.MouseDown += MouseDownHandler;
            parent.MouseMove += MouseMoveHandler;
            parent.MouseUp += MouseUpHandler;
        }

        private void pictureBoxClose_Click(object? sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            var farmer = new Farmer();
            int zoneId;
            bool isValidZoneId = int.TryParse(textBoxZoneId.Text.Trim(), out zoneId);


            if (!isValidZoneId)
            {
                MessageBox.Show("Geçerli bir Zone ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            farmer.ZoneId = zoneId;
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
                if (this.Owner is FarmerForm farmerForm)
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
            this.Close();
        }

        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
                this.BringToFront();
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
