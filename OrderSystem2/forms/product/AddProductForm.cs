using System.Globalization;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderSystem2.forms.product
{
    public partial class AddProductForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private ProductRepository _productRepository;
        private ProductService _productService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public AddProductForm()
        {
            InitializeComponent();

            _productRepository = new ProductRepository(_connectionString);
            _productService = new ProductService(_productRepository);

            buttonSave.Click += buttonSave_Click;
            pictureBoxClose.Click += pictureBoxClose_Click_1;

            Bind();

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

        private void buttonSave_Click(object sender, EventArgs e)
        {

            var product = new Product();
            int factoryId, categoryId, unitId, stock;
            bool isValidFactoryId = int.TryParse(textBoxFactory.Text.Trim(), out factoryId);
            bool isValidCategoryId = int.TryParse(textBoxCategory.Text.Trim(), out categoryId);
            bool isValidUnitId = int.TryParse(textBoxUnit.Text.Trim(), out unitId);
            double price = Convert.ToDouble(textBoxPrice.Text.Trim(), CultureInfo.InvariantCulture);
            bool isValidStock = int.TryParse(textBoxStok.Text.Trim(), out stock);



            if (!isValidFactoryId)
            {
                MessageBox.Show("Geçerli bir Zone ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            product.FactoryId = factoryId;
            product.CategoryId = categoryId;
            product.UnitId = unitId;
            product.Name = textBoxName.Text;
            product.Price = price;
            product.Stock = stock;


            try
            {
                _productService.Add(product);
                MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.Owner is ProductForm productForm)
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

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
