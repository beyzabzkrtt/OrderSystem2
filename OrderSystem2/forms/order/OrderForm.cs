using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem2.forms.order;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class OrderForm : Form
    {

        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private OrderRepository _orderRepository;
        private OrderService _orderService;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public OrderForm()
        {
            InitializeComponent();

            _orderRepository = new OrderRepository(_connectionString);
            _orderService = new OrderService(_orderRepository);

            LoadData();
            Bind();

            dataGridOrder.CellDoubleClick += dataGridOrder_CellDoubleClick;
            pictureBoxBack.Click += pictureBoxBack_Click;

        }

        private void LoadData()
        {
            var orders = _orderService.GetAll();

            dataGridOrder.AutoGenerateColumns = false;
            dataGridOrder.Columns.Clear();


            dataGridOrder.Columns.Add("Id", "Sipariş No");
            dataGridOrder.Columns["Id"].DataPropertyName = "Id";


            dataGridOrder.Columns.Add("UserId", "Kullanıcı No");
            dataGridOrder.Columns["UserId"].DataPropertyName = "UserId";

            dataGridOrder.Columns.Add("FarmerId", "Çiftçi No");
            dataGridOrder.Columns["FarmerId"].DataPropertyName = "FarmerId";

            dataGridOrder.Columns.Add("FieldId", "Tarla No");
            dataGridOrder.Columns["FieldId"].DataPropertyName = "FieldId";

            dataGridOrder.Columns.Add("Date", "Tarih");
            dataGridOrder.Columns["Date"].DataPropertyName = "Date";

            dataGridOrder.Columns.Add("TotalPrice", "Tutar");
            dataGridOrder.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            dataGridOrder.Columns.Add("Phone", "Telefon");
            dataGridOrder.Columns["Phone"].DataPropertyName = "Phone";

            dataGridOrder.Columns.Add("isCompleted", "Tamamlanmış");
            dataGridOrder.Columns["isCompleted"].DataPropertyName = "isCompleted";

            dataGridOrder.DataSource = orders;
            dataGridOrder.ReadOnly = true;
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

        private void dataGridOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedOrder = (Order)dataGridOrder.Rows[e.RowIndex].DataBoundItem;
                OrderItemsForm detailForm = new OrderItemsForm(selectedOrder);
                detailForm.Show();
            }
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
