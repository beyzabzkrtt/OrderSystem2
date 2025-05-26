
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class ProductForm : BaseForm
    {
        private ProductRepository _productRepository;
        private ProductService _productService;

        public ProductForm()
        {
            InitializeComponent();

            _productRepository = new ProductRepository();
            _productService = new ProductService(_productRepository);

            pictureBoxBack.Click += pictureBoxBack_Click;

            LoadData();
            AttachPanelDragEvents(panel1);

        }

        public void LoadData()
        {
            var products = _productService.GetAll();

            dataGridProduct.AutoGenerateColumns = false;
            dataGridProduct.Columns.Clear();


            dataGridProduct.Columns.Add("Id", "Ürün No");
            dataGridProduct.Columns["Id"].DataPropertyName = "Id";

            dataGridProduct.Columns.Add("CategoryId", "Kategori");
            dataGridProduct.Columns["CategoryId"].DataPropertyName = "CategoryId";

            dataGridProduct.Columns.Add("UnitId", "Birim");
            dataGridProduct.Columns["UnitId"].DataPropertyName = "UnitId";

            dataGridProduct.Columns.Add("Name", "İsim");
            dataGridProduct.Columns["Name"].DataPropertyName = "Name";

            dataGridProduct.Columns.Add("UnitPrice", "Fiyat");
            dataGridProduct.Columns["UnitPrice"].DataPropertyName = "UnitPrice";

            dataGridProduct.Columns.Add("Stock", "Stok");
            dataGridProduct.Columns["Stock"].DataPropertyName = "Stock";

            dataGridProduct.DataSource = products;
            dataGridProduct.ReadOnly = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
                this.Close();
        }       

        private void dataGridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedProduct = (Product)dataGridProduct.Rows[e.RowIndex].DataBoundItem;
                ProductDetailForm detailForm = new ProductDetailForm(selectedProduct);
                detailForm.Show();
            }
        }
    }
}
