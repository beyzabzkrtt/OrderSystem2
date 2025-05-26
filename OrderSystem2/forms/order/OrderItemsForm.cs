using OrderSystem2.forms.farmer;
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.order
{

    public partial class OrderItemsForm : BaseForm
    {

        private OrderRepository _orderRepository;
        private OrderService _orderService;

        private ProductRepository _productRepository;
        private ProductService _productService;

        private Order _order;

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
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();

        }

        private void LoadData()
        {
            var orderItems = _orderService.GetOrderItems(_order.Id);

            dataGridOrderItem.AutoGenerateColumns = false;
            dataGridOrderItem.Columns.Clear();

            dataGridOrderItem.Columns.Add("ProductName", "Ürün Adı");
            dataGridOrderItem.Columns["ProductName"].DataPropertyName = "ProductName";

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
      
        protected override void PictureBoxBack_Click(object sender, EventArgs e)
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
                    float stock = (float)product.Stock;
                    float newStock = stock + orderItem.Quantity;
                    _productService.UpdateStock(orderItem.ProductId, newStock);
                }

                _orderService.Delete(_order.Id);

                OrderForm orderForm = Application.OpenForms.OfType<OrderForm>().FirstOrDefault();
                if (orderForm != null)
                {
                    orderForm.LoadData();
                }

                FarmerOrderForm farmerOrderForm = Application.OpenForms.OfType<FarmerOrderForm>().FirstOrDefault();
                if (farmerOrderForm != null)
                {
                    farmerOrderForm.LoadOrders();
                }
                this.Close();
            }
        }
    }
}
