using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class FarmerFieldForm : Form
    {
        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private int _farmerId;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        public FarmerFieldForm(int id)
        {
            InitializeComponent();

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            _farmerId = id;

            LoadFields();
            Bind();
        }

        public void LoadFields()
        {
            var fields = _farmerService.GetFields(_farmerId);

            dataGridFarmerField.AutoGenerateColumns = false;
            dataGridFarmerField.Columns.Clear();

            dataGridFarmerField.Columns.Add("Id", "Tarla No");
            dataGridFarmerField.Columns["Id"].DataPropertyName = "Id";

            dataGridFarmerField.Columns.Add("AreaSize", "Tarla Büyüklüğü");
            dataGridFarmerField.Columns["AreaSize"].DataPropertyName = "AreaSize";

            dataGridFarmerField.DataSource = fields;
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
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
