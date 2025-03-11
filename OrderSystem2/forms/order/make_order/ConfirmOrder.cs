using System.Windows.Forms;
using OrderSystem2.dto;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.order.make_order
{
    public partial class ConfirmORder : Form
    {
        List<OrderItemDetail> orderItems = new List<OrderItemDetail>();

        private OrderRepository _orderRepository;
        private OrderService _orderService;

        private ProductRepository _productRepository;
        private ProductService _productService;

        private FieldRepository _fieldRepository;
        private FieldService _fieldService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private int _orderId;
        private OrderItemDetail _itemDetail;

        public ConfirmORder(int orderId)
        {
            InitializeComponent();

            _orderRepository = new OrderRepository();
            _orderService = new OrderService(_orderRepository);

            _productRepository = new ProductRepository();
            _productService = new ProductService(_productRepository);

            _fieldRepository = new FieldRepository();
            _fieldService = new FieldService(_fieldRepository);

            _orderId = orderId;

            buttonAdd.Click -= buttonAdd_Click;
            buttonAdd.Click += buttonAdd_Click;

            AttachPanelDragEvents(panel1);

        }

        public void LoadData(OrderItemDetail _itemDetail)
        {         
            orderItems.Add(_itemDetail);

            dataGridOrderItems.AutoGenerateColumns = false;
            dataGridOrderItems.Columns.Clear();

            dataGridOrderItems.Columns.Add("ProductName", "Ürün Adı");
            dataGridOrderItems.Columns["ProductName"].DataPropertyName = "ProductName";

            dataGridOrderItems.Columns.Add("AreaSize", "Tarla");
            dataGridOrderItems.Columns["AreaSize"].DataPropertyName = "AreaSize";

            dataGridOrderItems.Columns.Add("Quantity", "Miktar");
            dataGridOrderItems.Columns["Quantity"].DataPropertyName = "Quantity";

            dataGridOrderItems.Columns.Add("UnitName", "Birim");
            dataGridOrderItems.Columns["UnitName"].DataPropertyName = "UnitName";

            dataGridOrderItems.Columns.Add("UnitPrice", "Birim Fiyatı");
            dataGridOrderItems.Columns["UnitPrice"].DataPropertyName = "UnitPrice";

            dataGridOrderItems.Columns.Add("Price", "Fiyat");
            dataGridOrderItems.Columns["Price"].DataPropertyName = "Price";

            dataGridOrderItems.DataSource = orderItems;
            dataGridOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOrderItems.ReadOnly = true;

            var order = _orderService.GetById(_orderId);
            double total = order.TotalPrice;
            textBoxTotal.Text = total.ToString();
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
        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sipariş oluşturulmadı. Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                _orderService.Delete(_orderId);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var order = _orderService.GetById(_orderId);
            int farmerId = order.FarmerId;

            ChooseProduct chooseProduct = new ChooseProduct(farmerId, _orderId);
            chooseProduct.Show();
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            var orderItems = _orderService.GetAllOrderItems(_orderId);

            foreach (var orderItem in orderItems)
            { 
                var product = _productService.GetById(orderItem.ProductId);
                float stock = product.Stock;
                float newStock = stock - orderItem.Quantity;

                _productService.UpdateStock(orderItem.ProductId,newStock);
            }

            var result = MessageBox.Show("Ödeme alındı mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _orderService.UpdatePaid(_orderId, true);
            }
            else
            {
                _orderService.UpdatePaid(_orderId, false);
            }

            MessageBox.Show("Sipariş tamamlandı.");
            this.Close();
            
            

        }
    }

}

