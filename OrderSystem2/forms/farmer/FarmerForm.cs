using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class FarmerForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public FarmerForm()
        {
            InitializeComponent();

            _farmerRepository = new FarmerRepository(_connectionString);
            _farmerService = new FarmerService(_farmerRepository);

            LoadFarmer();
            AttachDragEvents(this);

            dataGridFarmer.CellDoubleClick += dataGridFarmer_CellDoubleClick;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
     
        }


        public void LoadFarmer()
        {
            var farmers = _farmerService.GetAll();

            dataGridFarmer.AutoGenerateColumns = false;
            dataGridFarmer.Columns.Clear();


            dataGridFarmer.Columns.Add("Id", "Çiftçi No");
            dataGridFarmer.Columns["Id"].DataPropertyName = "Id";

            dataGridFarmer.Columns.Add("ZoneId", "Bölge No");
            dataGridFarmer.Columns["ZoneId"].DataPropertyName = "ZoneId";

            dataGridFarmer.Columns.Add("Name", "Ad");
            dataGridFarmer.Columns["Name"].DataPropertyName = "Name";

            dataGridFarmer.Columns.Add("Surname", "Soyad");
            dataGridFarmer.Columns["Surname"].DataPropertyName = "Surname";

            dataGridFarmer.Columns.Add("Tc", "Tc");
            dataGridFarmer.Columns["Tc"].DataPropertyName = "Tc";

            dataGridFarmer.Columns.Add("Email", "Email");
            dataGridFarmer.Columns["Email"].DataPropertyName = "Email";

            dataGridFarmer.Columns.Add("Phone", "Telefon");
            dataGridFarmer.Columns["Phone"].DataPropertyName = "Phone";

            dataGridFarmer.Columns.Add("Address", "Adres");
            dataGridFarmer.Columns["Address"].DataPropertyName = "Address";

            dataGridFarmer.DataSource = farmers;
            dataGridFarmer.ReadOnly = true;
        }
        private void AttachDragEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!(ctrl is TextBox))  // TextBox'ları hariç tut, yoksa yazı yazarken sürüklenir.
                {
                    ctrl.MouseDown += MouseDownHandler;
                    ctrl.MouseMove += MouseMoveHandler;
                    ctrl.MouseUp += MouseUpHandler;
                }

                // Eğer kontrolün içinde başka kontroller varsa, onlara da ekle
                if (ctrl.HasChildren)
                {
                    AttachDragEvents(ctrl);
                }
            }
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

        private void dataGridFarmer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedFarmer = (Farmer)dataGridFarmer.Rows[e.RowIndex].DataBoundItem;
                FarmerDetail detailForm = new FarmerDetail(selectedFarmer);
                detailForm.Owner = this;
                detailForm.ShowDialog();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelAddFarmer_Click(object sender, EventArgs e)
        {
            AddFarmerForm addFarmerForm = new AddFarmerForm();
            addFarmerForm.Owner = this;
            addFarmerForm.Show();
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

        private void pictureBoxTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        

    }
}
