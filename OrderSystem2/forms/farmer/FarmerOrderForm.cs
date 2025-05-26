using OrderSystem2.entity;
using OrderSystem2.forms.order;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.farmer
{
    public partial class FarmerOrderForm : BaseForm
    {
        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private int _farmerId;

        public FarmerOrderForm(int id)
        {
            InitializeComponent();

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            _farmerId = id;

            dataGridFarmerField.CellDoubleClick += dataGridFarmerField_CellDoubleClick;

            LoadOrders();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();


        }

        public void LoadOrders()
        {
            var orders = _farmerService.GetOrders(_farmerId);

            dataGridFarmerField.AutoGenerateColumns = false;
            dataGridFarmerField.Columns.Clear();

            dataGridFarmerField.Columns.Add("Id", "Sipariş No");
            dataGridFarmerField.Columns["Id"].DataPropertyName = "Id";

            dataGridFarmerField.Columns.Add("Date", "Tarih");
            dataGridFarmerField.Columns["Date"].DataPropertyName = "Date";

            dataGridFarmerField.Columns.Add("TotalPrice", "Tutar");
            dataGridFarmerField.Columns["TotalPrice"].DataPropertyName = "TotalPrice";

            dataGridFarmerField.Columns.Add("isCompleted", "Tamamlanmış");
            dataGridFarmerField.Columns["isCompleted"].DataPropertyName = "isCompleted";

            dataGridFarmerField.DataSource = orders;
            dataGridFarmerField.ReadOnly = true;
        }

        private void dataGridFarmerField_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedOrder = (Order)dataGridFarmerField.Rows[e.RowIndex].DataBoundItem;
                OrderItemsForm orderItemsForm = new OrderItemsForm(selectedOrder);
                orderItemsForm.Show();
            }
        }
        
    }
}
