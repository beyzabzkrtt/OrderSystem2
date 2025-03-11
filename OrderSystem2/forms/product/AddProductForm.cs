using System.Globalization;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderSystem2.forms.product
{
    public partial class AddProductForm : Form
    {
        private ProductRepository _productRepository;
        private ProductService _productService;

        private FactoryRepository _factoryRepository;
        private FactoryService _factoryService;

        private CategoryRepository _categoryRepository;
        private CategoryService _categoryService;

        private UnitRepository _unitRepository;
        private UnitService _unitService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

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

            buttonSave.Click += buttonSave_Click;
            pictureBoxClose.Click += pictureBoxClose_Click;

            Bind();
            LoadCombobox();

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

        private void LoadCombobox()
        {
            var factories = _factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";


            comboBoxFactory.SelectedIndexChanged += comboBoxFactory_SelectedIndexChanged;

            var categories = _categoryService.GetAll();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";

            comboBoxCategory.DataSource = null;
            comboBoxCategory.Items.Clear();

            var units = _unitService.GetAll();
            comboBoxUnit.DataSource = units;
            comboBoxUnit.DisplayMember = "Name";
            comboBoxUnit.ValueMember = "Id";
        }

        private void comboBoxFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategories();

            if (comboBoxFactory.SelectedIndex != -1)
            {
                labelPlaceholder.Visible = false;
            }
            else
            {
                labelPlaceholder.Visible = true;
            }
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
            }
        }

        private bool AreAllFieldsFilled()
        {
            // Formdaki tüm textboxları ve comboboxları kontrol et
            bool allFilled = Controls.OfType<System.Windows.Forms.TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text)) &&
                             Controls.OfType<System.Windows.Forms.ComboBox>().All(cb => cb.SelectedIndex != -1);

            return allFilled;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kaydetme işlemi yapılmaz
            }

            var product = new Product();
            int stock;
       
            double price = Convert.ToDouble(textBoxPrice.Text.Trim(), CultureInfo.InvariantCulture);
            bool isValidStock = int.TryParse(textBoxStok.Text.Trim(), out stock);


            //product.FactoryId = Convert.ToInt32(comboBoxFactory.SelectedValue);
            product.CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
            product.UnitId = Convert.ToInt32(comboBoxUnit.SelectedValue);
            product.Name = textBoxName.Text;
            product.UnitPrice = price;
            product.Stock = stock;


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
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonSave_Enabled()
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
