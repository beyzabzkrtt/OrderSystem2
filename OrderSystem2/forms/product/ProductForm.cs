using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.product
{
    public partial class ProductForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private ProductRepository _productRepository;
        private ProductService _productService;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public ProductForm()
        {
            InitializeComponent();

            _productRepository = new ProductRepository(_connectionString);
            _productService = new ProductService(_productRepository);

            pictureBoxBack.Click += pictureBoxBack_Click;

            LoadData();
            Bind();
        }

        public void LoadData()
        {
            var products = _productService.GetAll();

            dataGridProduct.AutoGenerateColumns = false;
            dataGridProduct.Columns.Clear();


            dataGridProduct.Columns.Add("Id", "Ürün No");
            dataGridProduct.Columns["Id"].DataPropertyName = "Id";

            dataGridProduct.Columns.Add("FactoryId", "Fabrika No");
            dataGridProduct.Columns["FactoryId"].DataPropertyName = "FactoryId";

            dataGridProduct.Columns.Add("CategoryId", "Kategori");
            dataGridProduct.Columns["CategoryId"].DataPropertyName = "CategoryId";

            dataGridProduct.Columns.Add("UnitId", "Birim");
            dataGridProduct.Columns["UnitId"].DataPropertyName = "UnitId";

            dataGridProduct.Columns.Add("Name", "İsim");
            dataGridProduct.Columns["Name"].DataPropertyName = "Name";

            dataGridProduct.Columns.Add("Price", "Fiyat");
            dataGridProduct.Columns["Price"].DataPropertyName = "Price";

            dataGridProduct.Columns.Add("Stock", "Stok");
            dataGridProduct.Columns["Stock"].DataPropertyName = "Stock";

            dataGridProduct.Columns.Add("Address", "Adres");
            dataGridProduct.Columns["Address"].DataPropertyName = "Address";

            dataGridProduct.DataSource = products;
            dataGridProduct.ReadOnly = true;

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
