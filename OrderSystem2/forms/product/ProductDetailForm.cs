using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class ProductDetailForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private ProductRepository _productRepository;
        private ProductService _productService;

        private Product _product;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public ProductDetailForm(Product product)
        {
            InitializeComponent();

            _productRepository = new ProductRepository(_connectionString);
            _productService = new ProductService(_productRepository);

            _product = product;

            LoadDetail();

            buttonSave.Click += buttonSave_Click;
            buttonDelete.Click += buttonDelete_Click;

            Bind();

        }

        public void LoadDetail()
        {
            textBoxProductNo.Text = _product.Id.ToString();
            textBoxProductNo.ReadOnly = true;
            textBoxFactoryNo.Text = _productService.GetFactoryName(_product.Id);
            textBoxFactoryNo.ReadOnly = true;
            textBoxCategoryNo.Text = _productService.GetCategoryName(_product.Id);
            textBoxCategoryNo.ReadOnly = true;
            textBoxUnitNo.Text = _productService.GetUnitName(_product.Id);
            textBoxUnitNo.ReadOnly = true;
            textBoxName.Text = _product.Name;
            textBoxPrice.Text = _product.Price.ToString();
            textBoxStock.Text = _product.Stock.ToString();
            textBoxCreatedBy.Text = _product.CreatedBy.ToString();
            textBoxCreatedBy.ReadOnly = true;
            textBoxCreatedAt.Text = _product.CreatedAt.ToString();
            textBoxCreatedAt.ReadOnly = true;
            textBoxUpdatedBy.Text = _product.UpdatedBy.ToString();
            textBoxUpdatedBy.ReadOnly = true;
            textBoxupdatedAt.Text = _product.UpdatedAt.ToString();
            textBoxUpdatedBy.ReadOnly = true;
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

            try
            {
                _product.Name = textBoxName.Text;
                _product.Price = double.Parse(textBoxPrice.Text);
                _product.Stock = int.Parse(textBoxStock.Text);

                _productService.Update(_product, _product.Id);

                MessageBox.Show("Güncelleme başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.Owner is ProductForm productForm)
                {
                    productForm.LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?",
                                        "Onay",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _productService.Delete(_product.Id);

                    MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                prevBounds = this.Bounds;

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                pictureBoxExpand.Image = Image.FromFile("C:\\Users\\beboz\\source\\repos\\OrderSystem2\\OrderSystem2\\Resources\\contract.png");
                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Bounds = prevBounds;

                pictureBoxExpand.Image = Image.FromFile("C:\\Users\\beboz\\source\\repos\\OrderSystem2\\OrderSystem2\\Resources\\expand.png");
                isFullScreen = false;
            }
        }

        private void pictureBoxTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
