using OrderSystem2.forms.order;
using OrderSystem2.model;
using OrderSystem2.Properties;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class OrderForm : BaseForm
    {       

        private OrderRepository _orderRepository;
        private OrderService _orderService;

        public OrderForm()
        {
            InitializeComponent();

            _orderRepository = new OrderRepository();
            _orderService = new OrderService(_orderRepository);

            LoadData();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();


            dataGridOrder.CellDoubleClick += dataGridOrder_CellDoubleClick;

        }

        public void LoadData()
        {
            var orders = _orderService.GetAll();

            dataGridOrder.AutoGenerateColumns = false;
            dataGridOrder.Columns.Clear();


            dataGridOrder.Columns.Add("Id", "Sipariş No");
            dataGridOrder.Columns["Id"].DataPropertyName = "Id";

            dataGridOrder.Columns.Add("FarmerId", "Çiftçi No");
            dataGridOrder.Columns["FarmerId"].DataPropertyName = "FarmerId";

            dataGridOrder.Columns.Add("Date", "Tarih");
            dataGridOrder.Columns["Date"].DataPropertyName = "Date";

            dataGridOrder.Columns.Add("TotalPrice", "Tutar");
            dataGridOrder.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            dataGridOrder.Columns.Add("isCompleted", "Tamamlanmış");
            dataGridOrder.Columns["isCompleted"].DataPropertyName = "isCompleted";

            dataGridOrder.DataSource = orders;
            dataGridOrder.ReadOnly = true;
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
     
    }
}
