using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.farmer
{
    public partial class FarmerOrderForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private int _farmerId;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public FarmerOrderForm(int id)
        {
            InitializeComponent();

            _farmerRepository = new FarmerRepository(_connectionString);
            _farmerService = new FarmerService(_farmerRepository);

            _farmerId = id;

            LoadOrders();
            Bind();

        }

        public void LoadOrders()
        {
            var orders = _farmerService.GetOrders(_farmerId);

            dataGridFarmerField.AutoGenerateColumns = false;
            dataGridFarmerField.Columns.Clear();

            dataGridFarmerField.Columns.Add("Id", "Sipariş No");
            dataGridFarmerField.Columns["Id"].DataPropertyName = "Id";

            dataGridFarmerField.Columns.Add("UserId", "Kullanıcı No");
            dataGridFarmerField.Columns["UserId"].DataPropertyName = "UserId";

            dataGridFarmerField.Columns.Add("FieldId", "Tarla No");
            dataGridFarmerField.Columns["FieldId"].DataPropertyName = "FieldId";

            dataGridFarmerField.Columns.Add("Date", "Tarih");
            dataGridFarmerField.Columns["Date"].DataPropertyName = "Date";

            dataGridFarmerField.Columns.Add("TotalPrice", "Tutar");
            dataGridFarmerField.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            dataGridFarmerField.Columns.Add("isCompleted", "Tamamlanmış");
            dataGridFarmerField.Columns["isCompleted"].DataPropertyName = "isCompleted";

            dataGridFarmerField.DataSource = orders;
            dataGridFarmerField.ReadOnly = true;
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

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBoxTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
