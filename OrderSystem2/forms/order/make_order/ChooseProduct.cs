using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;
using Constraint = OrderSystem2.entity.Constraint;

namespace OrderSystem2.forms.order.make_order
{
    public partial class ChooseProduct : Form
    {
        private int _farmerId;
        private int _fieldId;
        private int _orderId;

        private FarmerRepository farmerRepository;
        private FarmerService farmerService;

        private FactoryRepository factoryRepository;
        private FactoryService factoryService;

        private CategoryRepository categoryRepository;
        private CategoryService categoryService;

        private FieldRepository fieldRepository;
        private FieldService fieldService;

        private ConstraintRepository constraintRepository;
        private ConstraintService constraintService;

        private OrderRepository orderRepository;
        private OrderService orderService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public ChooseProduct(int farmerId, int orderId)
        {
            InitializeComponent();

            _farmerId = farmerId;
            _orderId = orderId;

            farmerRepository = new FarmerRepository();
            farmerService = new FarmerService(farmerRepository);

            factoryRepository = new FactoryRepository();
            factoryService = new FactoryService(factoryRepository);

            categoryRepository = new CategoryRepository();
            categoryService = new CategoryService(categoryRepository);

            fieldRepository = new FieldRepository();
            fieldService = new FieldService(fieldRepository);

            constraintRepository = new ConstraintRepository();
            constraintService = new ConstraintService(constraintRepository);

            orderRepository = new OrderRepository();
            orderService = new OrderService(orderRepository);

            buttonLater.Enabled = false;

            LoadData();
            AttachPanelDragEvents(panel1);

        }

        private void LoadData()
        {
            textBoxFarmerId.Text = _farmerId.ToString();

            comboBoxField.Enabled = true;
            var fields = farmerRepository.GetFields(_farmerId);
            comboBoxField.DataSource = fields;
            comboBoxField.DisplayMember = "AreaSize";
            comboBoxField.ValueMember = "Id";
            buttonLater.Enabled = false;

            comboBoxField.SelectedIndexChanged += ComboBoxField_SelectedIndexChanged;

        }

        private void ComboBoxField_SelectedIndexChanged(object? sender, EventArgs e)
        {
            labelPlaceHolderField.Visible = false;

            comboBoxFactory.Enabled = true;
            var factories = factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";

            comboBoxFactory.SelectedIndexChanged += ComboBoxFactory_SelectedIndexChanged;
        }

        private void ComboBoxFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonLater.Enabled = false;
            comboBoxCategory.SelectedIndexChanged -= ComboBoxCategory_SelectedIndexChanged;

            if (comboBoxFactory.SelectedValue != null)
            {
                labelPlaceholder.Visible = false;
                labelPlaceHolder2.Visible = true;
                labelPlaceHolder3.Visible = true;


                int factoryId = Convert.ToInt32(comboBoxFactory.SelectedValue);

                comboBoxCategory.Enabled = true;
                var categories = factoryService.GetCategories(factoryId);
                comboBoxCategory.DataSource = null;
                comboBoxCategory.DisplayMember = "Name";
                comboBoxCategory.ValueMember = "Id";
                comboBoxCategory.DataSource = categories;
                labelPlaceHolder2.Visible = true;

                comboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
            }
            else
            {
                comboBoxCategory.DataSource = null;
                comboBoxCategory.Items.Clear();

                labelPlaceholder.Visible = true;
                labelPlaceHolder2.Visible = true;
                labelPlaceHolder3.Visible = true;
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonLater.Enabled = false;
            comboBoxProduct.SelectedIndexChanged -= ComboBoxProduct_SelectedIndexChanged;
            comboBoxProduct.DataSource = null;
            comboBoxProduct.Items.Clear();

            if (comboBoxCategory.SelectedValue != null)
            {
                labelPlaceHolder2.Visible = false;

                int categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);

                comboBoxProduct.Enabled = true;
                var products = categoryService.GetProducts(categoryId);
                comboBoxProduct.DataSource = null;
                comboBoxProduct.DataSource = products;
                comboBoxProduct.DisplayMember = "Name";
                comboBoxProduct.ValueMember = "Id";
            }
            else
            {
                labelPlaceHolder2.Visible = true;
            }

            comboBoxProduct.SelectedIndexChanged += ComboBoxProduct_SelectedIndexChanged;
        }

        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedIndex != -1)
            {
                labelPlaceHolder3.Visible = false;
                buttonLater.Visible = true;
            }
            else
            {
                labelPlaceHolder3.Visible = true;
            }
            try
            {
                int productId = Convert.ToInt32(comboBoxProduct.SelectedValue);
                _fieldId = Convert.ToInt32(comboBoxField.SelectedValue);
                Field field = fieldService.GetById(_fieldId);

                Constraint minFieldConstraint = constraintService.GetMinByProductId(productId);


                if (field.AreaSize != null && minFieldConstraint != null)
                {
                    double value = Convert.ToDouble(minFieldConstraint.Value);

                    try
                    {
                        if (value > field.AreaSize)
                        {
                            comboBoxProduct.SelectedIndex = -1;
                            labelPlaceHolder3.Visible = true;
                            throw new Exception();
                        }
                        else
                        {
                            buttonLater.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Uyarı: Seçili tarla için bu üründen sipariş edilemez.",
                                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonLater.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: Ürün için henüz bir kısıt girilmemiş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonLater.Enabled = false;
            }

        }

        private void buttonLater_Click(object sender, EventArgs e)
        {

            int productId = Convert.ToInt32(comboBoxProduct.SelectedValue);

            AmountEntry amountEntry = new AmountEntry(productId, _fieldId, _orderId);
            amountEntry.Owner = this;
            amountEntry.ShowDialog();


        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            ConfirmORder confirmORder = Application.OpenForms.OfType<ConfirmORder>().FirstOrDefault();
            if (confirmORder != null)
            {
                var result = MessageBox.Show("Ürün eklenmedi. Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            else
            {
                var result = MessageBox.Show("Sipariş iptal edilsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    orderService.Delete(_orderId);
                    this.Close();

                }
            }

        }
        private void AttachPanelDragEvents(Panel panel)
        {
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = ((Control)sender).PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

    }
}
