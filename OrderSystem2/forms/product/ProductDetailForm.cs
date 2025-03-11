using System.Diagnostics;
using System.Windows.Forms;
using OrderSystem2.forms.order.make_order;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class ProductDetailForm : Form
    {
        private ProductRepository _productRepository;
        private ProductService _productService;

        private Product _product;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private Dictionary<TextBox, string> initialValues;

        public ProductDetailForm(Product product)
        {
            InitializeComponent();

            _productRepository = new ProductRepository();
            _productService = new ProductService(_productRepository);

            _product = product;

            LoadDetail();

            buttonSave.Click -= buttonSave_Click;
            buttonSave.Click += buttonSave_Click;

            buttonDelete.Click -= buttonDelete_Click;
            buttonDelete.Click += buttonDelete_Click;

            buttonSave.Enabled = false;

            Bind(); 

            foreach (var control in Controls.OfType<TextBox>())
            {
                control.TextChanged -= MarkAsChanged;
                control.TextChanged += MarkAsChanged;
            }

            SaveInitialValues();

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
            textBoxPrice.Text = _product.UnitPrice.ToString();
            textBoxStock.Text = _product.Stock.ToString();
        }

        private void SaveInitialValues()
        {
            initialValues = Controls.OfType<TextBox>()
                   .ToDictionary(tb => tb, tb => tb.Text);
            Debug.WriteLine("Initial Values Saved: ");

            foreach (var entry in initialValues)
            {
                Debug.WriteLine($"Textbox Name: {entry.Key.Name}, Value: {entry.Value}");
            }
        }

        private bool HasChanges()
        {           
            return Controls.OfType<TextBox>().Any(tb => tb.Text != initialValues[tb]);
        }

        private bool AreAllFieldsFilled()
        {
            return Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }

        private void MarkAsChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = HasChanges();
        }      

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _product.Name = textBoxName.Text;
                _product.UnitPrice = double.Parse(textBoxPrice.Text);
                _product.Stock = int.Parse(textBoxStock.Text);

                _productService.Update(_product, _product.Id);

                MessageBox.Show("Güncelleme başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveInitialValues();
                buttonSave.Enabled = false;

                ProductForm productForm = Application.OpenForms.OfType<ProductForm>().FirstOrDefault();
                if (productForm != null)
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
    }
}
