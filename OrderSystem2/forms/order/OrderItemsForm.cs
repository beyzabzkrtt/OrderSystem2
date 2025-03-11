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

        private ProductRepository _productRepository;
        private ProductService _productService;

        private Order _order;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public OrderItemsForm(Order order)
        {
            InitializeComponent();

            _orderRepository = new OrderRepository();
            _orderService = new OrderService(_orderRepository);

            _productRepository = new ProductRepository();
            _productService = new ProductService(_productRepository);

            _order = order;

            LoadData();
            LoadLabels();
            Bind();
        }

        private void LoadData()
        {
            var orderItems = _orderService.GetOrderItems(_order.Id);

            dataGridOrderItem.AutoGenerateColumns = false;
            dataGridOrderItem.Columns.Clear();

            dataGridOrderItem.Columns.Add("ProductName", "Ürün Adı");
            dataGridOrderItem.Columns["ProductName"].DataPropertyName = "ProductName";

            dataGridOrderItem.Columns.Add("AreaSize", "Tarla");
            dataGridOrderItem.Columns["AreaSize"].DataPropertyName = "AreaSize";

            dataGridOrderItem.Columns.Add("Quantity", "Miktar");
            dataGridOrderItem.Columns["Quantity"].DataPropertyName = "Quantity";

            dataGridOrderItem.Columns.Add("Unitname", "Birim");
            dataGridOrderItem.Columns["UnitName"].DataPropertyName = "UnitName";

            dataGridOrderItem.Columns.Add("UnitPrice", "Birim Fiyatı");
            dataGridOrderItem.Columns["UnitPrice"].DataPropertyName = "UnitPrice";

            dataGridOrderItem.Columns.Add("Price", "Fiyat");
            dataGridOrderItem.Columns["Price"].DataPropertyName = "Price";

            dataGridOrderItem.DataSource = orderItems;
            dataGridOrderItem.ReadOnly = true;

            labelCanceled.Visible = false;
            labelCanceled.Enabled = false;
            labelCompleted.Visible = false;
            labelCompleted.Enabled = false;
            labelPaid.Visible = false;
            labelPaid.Enabled = false;
        }
        private void LoadLabels()
        {
            bool isCompleted, isPaid;
            isCompleted = _order.isCompleted;
            isPaid = _order.isPaid;

            if (!isCompleted)
            {
                labelCompleted.Visible = true;
                labelCompleted.Enabled = true;
            }

            if (!isPaid)
            {
                labelPaid.Visible = true;
                labelPaid.Enabled = true;
            }

            if(!isCompleted && !isPaid)
            {
                labelCanceled.Visible = true;
                labelCanceled.Enabled = true;
            } 
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
            OrderForm orderForm = Application.OpenForms.OfType<OrderForm>().FirstOrDefault();
            if (orderForm != null)
            {
                orderForm.LoadData();
            }
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
            OrderForm orderForm = Application.OpenForms.OfType<OrderForm>().FirstOrDefault();
            if (orderForm != null)
            {
                orderForm.LoadData();
            }
            this.Close();
        }

        private void labelCompleted_Click(object sender, EventArgs e)
        {
            _orderService.UpdateCompleted(_order.Id, true);
            MessageBox.Show("Sipariş 'Tamamlandı' olarak güncellendi");
            labelCompleted.Visible = false;
            labelCompleted.Enabled = false;
            labelCanceled.Enabled = false;
            labelCanceled.Visible = false;
        }

        private void labelPaid_Click(object sender, EventArgs e)
        {
            _orderService.UpdatePaid(_order.Id, true);
            MessageBox.Show("Ödeme bilgisi 'Tamamlandı' olarak güncellendi");
            labelPaid.Visible = false;
            labelPaid.Enabled = false;
            labelCanceled.Enabled = false;
            labelCanceled.Visible = false;
        }

        private void labelCanceled_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Siparişi iptal etmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var orderItems = _orderService.GetAllOrderItems(_order.Id);

                foreach (var orderItem in orderItems)
                {
                    var product = _productService.GetById(orderItem.ProductId);
                    float stock = product.Stock;
                    float newStock = stock + orderItem.Quantity;
                    _productService.UpdateStock(orderItem.ProductId, newStock);
                }

                _orderService.Delete(_order.Id);

                OrderForm orderForm = Application.OpenForms.OfType<OrderForm>().FirstOrDefault();
                if (orderForm != null)
                {
                    orderForm.LoadData();
                }
                this.Close();
            }
        }
    }
}
