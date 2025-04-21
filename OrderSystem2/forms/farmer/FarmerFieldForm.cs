using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class FarmerFieldForm : BaseForm
    {
        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private int _farmerId;
       
        public FarmerFieldForm(int id)
        {
            InitializeComponent();

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            _farmerId = id;

            LoadFields();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();
            
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
           
    }
}
