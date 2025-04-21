using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class ProductConstraintForm : BaseForm
    {
        private int _productId;

        private ConstraintRepository _constraintRepository;
        private ConstraintService _constraintService;

        public ProductConstraintForm(int productId)
        {

            InitializeComponent();

            _constraintRepository = new ConstraintRepository();
            _constraintService = new ConstraintService(_constraintRepository);

            _productId = productId;

            AttachPanelDragEvents(panel1);

            LoadData();
        }

        private void LoadData()
        {
            var constraints = _constraintService.GetListById(_productId);

            dataGridConstraint.AutoGenerateColumns = false;
            dataGridConstraint.Columns.Clear();


            dataGridConstraint.Columns.Add("Id", "Kısıt No");
            dataGridConstraint.Columns["Id"].DataPropertyName = "Id";

            dataGridConstraint.Columns.Add("ProductId", "Ürün No");
            dataGridConstraint.Columns["ProductId"].DataPropertyName = "ProductId";

            dataGridConstraint.Columns.Add("ConstraintType", "Kısıt Tipi");
            dataGridConstraint.Columns["ConstraintType"].DataPropertyName = "ConstraintType";

            dataGridConstraint.Columns.Add("Value", "Value");
            dataGridConstraint.Columns["Value"].DataPropertyName = "Value";

            dataGridConstraint.Columns.Add("Description", "Açıklama");
            dataGridConstraint.Columns["Description"].DataPropertyName = "Description";


            dataGridConstraint.DataSource = constraints;
            dataGridConstraint.ReadOnly = true;
        }

    }
}
