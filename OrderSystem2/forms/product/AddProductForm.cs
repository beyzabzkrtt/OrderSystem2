using System.Globalization;
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class AddProductForm : AddBaseForm
    {
        private ProductRepository _productRepository;
        private ProductService _productService;

        private FactoryRepository _factoryRepository;
        private FactoryService _factoryService;

        private CategoryRepository _categoryRepository;
        private CategoryService _categoryService;

        private UnitRepository _unitRepository;
        private UnitService _unitService;

        public AddProductForm()
        {
            InitializeComponent();

            _productRepository = new ProductRepository();
            _productService = new ProductService(_productRepository);

            _categoryRepository = new CategoryRepository();
            _categoryService = new CategoryService(_categoryRepository);

            _unitRepository = new UnitRepository();
            _unitService = new UnitService(_unitRepository);

            _factoryRepository = new FactoryRepository();
            _factoryService = new FactoryService(_factoryRepository);

            buttonSave.Click -= buttonSave_Click;
            buttonSave.Click += buttonSave_Click;
            pictureBoxClose.Click -= pictureBoxClose_Click;
            pictureBoxClose.Click += pictureBoxClose_Click;

            AttachPanelDragEvents(panel2);
            LoadCombobox();

            labelPlaceholder.Visible = true;
            labelCategory.Visible = true;
            labelUnit.Visible = true;

        }

        private void LoadCombobox()
        {
            var factories = _factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";


            comboBoxFactory.SelectedIndexChanged += comboBoxFactory_SelectedIndexChanged;

            

            comboBoxCategory.DataSource = null;
            comboBoxCategory.Items.Clear();
       
        }

        private void comboBoxFactory_SelectedIndexChanged(object sender, EventArgs e)
        {            

            if (comboBoxFactory.SelectedIndex != -1)
            {
                labelPlaceholder.Visible = false;
            }
            else
            {
                labelPlaceholder.Visible = true;
            }

            LoadCategories();

        }

        private void LoadCategories()
        {
            if (comboBoxFactory.SelectedValue != null)
            {
                int selectedFactoryId;

                if (comboBoxFactory.SelectedValue is int)
                {
                    selectedFactoryId = (int)comboBoxFactory.SelectedValue;
                }
                else
                {
                    return;
                }

                var categories = _categoryService.GetCategoryByFactory(selectedFactoryId);

                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "Name";
                comboBoxCategory.ValueMember = "Id";

                comboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != -1)
            {
                labelCategory.Visible = false;
            }
            else
            {
                labelCategory.Visible = true;
            }

            var units = _unitService.GetAll();
               comboBoxUnit.DataSource = units;
               comboBoxUnit.DisplayMember = "Name";
               comboBoxUnit.ValueMember = "Id";

            comboBoxUnit.SelectedIndexChanged += ComboBoxUnit_SelectedIndexChanged;
        }

        private void ComboBoxUnit_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxUnit.SelectedIndex != -1)
            {
                labelUnit.Visible = false;
            }
            else
            {
                labelUnit.Visible = true;
            }
        }

        private bool AreAllFieldsFilled()
        {
            bool allFilled = Controls.OfType<System.Windows.Forms.TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text)) &&
                             Controls.OfType<System.Windows.Forms.ComboBox>().All(cb => cb.SelectedIndex != -1);

            return allFilled;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                var product = new Product();

                try
                {
                    double price = Convert.ToDouble(textBoxPrice.Text.Trim(), CultureInfo.InvariantCulture);
                    double stock = Convert.ToDouble(textBoxStok.Text.Trim(), CultureInfo.InvariantCulture);

                    product.CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
                    product.UnitId = Convert.ToInt32(comboBoxUnit.SelectedValue);
                    product.Name = textBoxName.Text;
                    product.UnitPrice = price;
                    product.Stock =stock;

                  try
                  {
                     _productService.Add(product);
                        MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ProductForm productForm = Application.OpenForms.OfType<ProductForm>().FirstOrDefault();
                        if (productForm != null)
                        {
                         productForm.LoadData();
                     }
                     this.Close();
                   }
                   catch (Exception ex)
                   {
                        MessageBox.Show($"Ürün eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen geçerli değer girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            

        protected override void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ürün eklenmedi! Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); ;
            }
        }
       
    }
}
