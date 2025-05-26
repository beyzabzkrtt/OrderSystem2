using System;
using System.Data;
using OrderSystem2.dto;
using OrderSystem2.entity;
using OrderSystem2.forms.order.make_order;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;
using Constraint = OrderSystem2.entity.Constraint;

namespace OrderSystem2.forms.order
{
    public partial class AmountEntry : Form
    {
        private FieldRepository fieldRepository;
        private FieldService fieldService;

        private ProductRepository productRepository;
        private ProductService productService;

        private ConstraintRepository constraintRepository;
        private ConstraintService constraintService;

        private OrderItemRepository orderItemRepository;
        private OrderItemService orderItemService;

        private UnitRepository unitRepository;
        private UnitService unitService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private int _fieldId;
        private int _productId;
        private int _orderId;

        public Constraint minFieldConstraint;
        public Constraint maxAmountConstraint;

        public AmountEntry(int productId, int fieldId, int orderId)
        {

            _fieldId = fieldId;
            _productId = productId;
            _orderId = orderId;

            InitializeComponent();

            fieldRepository = new FieldRepository();
            fieldService = new FieldService(fieldRepository);

            productRepository = new ProductRepository();
            productService = new ProductService(productRepository);

            constraintRepository = new ConstraintRepository();
            constraintService = new ConstraintService(constraintRepository);

            orderItemRepository = new OrderItemRepository();
            orderItemService = new OrderItemService(orderItemRepository);

            unitRepository = new UnitRepository();
            unitService = new UnitService(unitRepository);

            minFieldConstraint = constraintService.GetMinByProductId(_productId);
            maxAmountConstraint = constraintService.GetMaxByProductId(_productId);


            buttonConfirm.Enabled = false;

            textBoxAmount.TextChanged += TextBoxAmount_TextChanged;

            LoadData();
            Calculate();
            AttachPanelDragEvents(panel1);

        }

        private void TextBoxAmount_TextChanged(object? sender, EventArgs e)
        {
            buttonConfirm.Enabled = true;
        }

        private void LoadData()
        {
            Field field = fieldService.GetById(_fieldId);
            textBoxAreaSize.Text = field.AreaSize.ToString();
            textBoxAreaSize.ReadOnly = true;

            Product product = productService.GetById(_productId);
            textBoxProduct.Text = product.Name;
            textBoxProduct.ReadOnly = true;

            try
            {
                if (minFieldConstraint == null)
                {
                    throw new Exception();
                }
                else
                {
                    if (maxAmountConstraint == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        textBoxCondition.Text = minFieldConstraint.Description;
                        textBoxLimit.Text = maxAmountConstraint.Description;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: Ürün için henüz bir kısıt girilmemiş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Calculate()
        {
            try
            {
                string formula = maxAmountConstraint.Value.ToString();
                decimal areaSize = Convert.ToDecimal(textBoxAreaSize.Text);

                string expression = formula.Replace("AreaSize", areaSize.ToString());

                object result = new DataTable().Compute(expression, "");

                decimal calculatedValue = Convert.ToDecimal(result);

                Product product = productService.GetById(_productId);
                decimal stock = (decimal)product.Stock;

                if (calculatedValue > stock)
                {
                    MessageBox.Show("Stok alabileceğiniz miktardan az.");
                    double amount = Convert.ToDouble(stock);
                    textBoxMaxAmount.Text = amount.ToString();
                }
                else
                {
                    double amount = Convert.ToDouble(calculatedValue);
                    textBoxMaxAmount.Text = amount.ToString();                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Hata: Ürün için henüz bir kısıt girilmemiş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            double maxAmount = Convert.ToDouble(textBoxMaxAmount.Text);
            double amount = Convert.ToDouble(textBoxAmount.Text);

            if(maxAmount < amount)
            {
                MessageBox.Show("Alınabilecek maksimum tutar aşıldı");
            }
            else
            {
                Product product = productService.GetById(_productId);
                int unitPrice = (int)product.UnitPrice;
                Unit unit = unitService.GetById(product.UnitId);
                Field field = fieldService.GetById(_fieldId);

                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = _orderId;
                orderItem.ProductId = _productId;
                orderItem.Quantity = (float)amount;
                orderItem.Price = (float)(amount * unitPrice);                
                orderItemService.Add(orderItem);

                OrderItemDetail detail = new OrderItemDetail();
                detail.ProductName = product.Name;
                detail.Quantity = (float)amount;
                detail.UnitName = unit.Name;
                detail.UnitPrice = unitPrice;
                detail.AreaSize = (decimal)field.AreaSize;
                detail.Price = (decimal)(unitPrice * amount);
                fieldRepository.SetUsed(_fieldId,true);

                MessageBox.Show("Ürün eklendi");
                   

                ConfirmORder confirm = Application.OpenForms.OfType<ConfirmORder>().FirstOrDefault();
                if(confirm != null)
                {
                    confirm.LoadData(detail);
                    confirm.Activate();
                    confirm.Focus();
                    confirm.BringToFront();
                }
                else
                {
                    ConfirmORder confirmORder = new ConfirmORder(_orderId,_fieldId);
                    confirmORder.LoadData(detail);
                    confirmORder.Show();
                }
                
                
                ChooseProduct chooseProduct = Application.OpenForms.OfType<ChooseProduct>().FirstOrDefault();
                if (chooseProduct != null)
                {
                    chooseProduct.Close();
                }
                this.Close();

                MakeOrderForm makeOrderForm = Application.OpenForms.OfType<MakeOrderForm>().FirstOrDefault();
                if (makeOrderForm != null)
                {
                    makeOrderForm.Close();
                }
                this.Close();
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ürün eklenmedi. Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();                

            }
            
        }

    }
}
