using System.Diagnostics;
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class ProductDetailForm : BaseForm
    {
        private ProductRepository _productRepository;
        private ProductService _productService;

        private Product _product;

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

            AttachPanelDragEvents(panel1);
            

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
                bool canDeleteO = _productService.HasOrders(_product.Id);
                bool canDeleteS = _productService.HasAnyStocks(_product.Id);
                if(canDeleteO)
                {
                    if(canDeleteS)
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
                    else
                    {
                        MessageBox.Show($"Ürün silinemiyor! Stoğu mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show($"Ürün silinemiyor! Sipariş için kullanılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ProductConstraintForm productConstraintForm = new ProductConstraintForm(_product.Id);
            productConstraintForm.Show();
        }

    }
}
