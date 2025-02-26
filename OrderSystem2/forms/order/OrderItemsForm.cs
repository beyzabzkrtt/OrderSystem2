using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.order
{

    public partial class OrderItemsForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private OrderRepository _orderRepository;
        private OrderService _orderService;

        private Order _order;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public OrderItemsForm(Order order)
        {
            InitializeComponent();

            _orderRepository = new OrderRepository(_connectionString);
            _orderService = new OrderService(_orderRepository);

            _order = order;

            LoadData();
            Bind();
        }

        private void LoadData()
        {
            var orderItems = _orderService.GetOrderItems(_order.Id);

            dataGridOrderItem.AutoGenerateColumns = false;
            dataGridOrderItem.Columns.Clear();


            dataGridOrderItem.Columns.Add("OrderId", "Sipariş No");
            dataGridOrderItem.Columns["OrderId"].DataPropertyName = "OrderId";


            dataGridOrderItem.Columns.Add("ProductId", "Ürün No");
            dataGridOrderItem.Columns["ProductId"].DataPropertyName = "ProductId";

            dataGridOrderItem.Columns.Add("UnitId", "Birim No");
            dataGridOrderItem.Columns["UnitId"].DataPropertyName = "UnitId";

            dataGridOrderItem.Columns.Add("UnitPrice", "Birim Fiyatı");
            dataGridOrderItem.Columns["UnitPrice"].DataPropertyName = "UnitPrice";

            dataGridOrderItem.Columns.Add("Quantity", "Adet");
            dataGridOrderItem.Columns["Quantity"].DataPropertyName = "Quantity";

            dataGridOrderItem.DataSource = orderItems;
            dataGridOrderItem.ReadOnly = true;
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
