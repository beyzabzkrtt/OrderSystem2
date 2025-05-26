using OrderSystem2.entity;
using OrderSystem2.forms.order.make_order;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;
using System;

namespace OrderSystem2.forms.order
{
    public partial class MakeOrderForm : Form
    {       
        private FarmerRepository farmerRepository;
        private FarmerService farmerService;

        private OrderRepository orderRepository;
        private OrderService orderService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private int _orderId;

        private System.Windows.Forms.Timer inputTimer;


        public MakeOrderForm()
        {
            farmerRepository = new FarmerRepository();
            farmerService = new FarmerService(farmerRepository);

            orderRepository = new OrderRepository();
            orderService = new OrderService(orderRepository);

            InitializeComponent();
            AttachPanelDragEvents(panel1);

            textBoxFarmerId.TextChanged += textBoxFarmerId_TextChanged;

            inputTimer = new System.Windows.Forms.Timer();
            inputTimer.Interval = 600;
            inputTimer.Tick += InputTimer_Tick;


            buttonLater.Enabled = false;
        }

        private void textBoxFarmerId_TextChanged(object sender, EventArgs e)
        {
            inputTimer.Stop();
            inputTimer.Start();
        }

        private void InputTimer_Tick(object sender, EventArgs e)
        {
            inputTimer.Stop();

            string input = textBoxFarmerId.Text.Trim();

            if (!int.TryParse(input, out int farmerId))
            {
                MessageBox.Show("Lütfen geçerli bir numara girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool farmerCheck = farmerService.IsFarmerExists(farmerId);

            if (farmerCheck)
            {
                buttonLater.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bu ID'ye sahip bir çiftçi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonLater.Enabled = false;
            }
        }

        private void buttonLater_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.FarmerId = Convert.ToInt32(textBoxFarmerId.Text);
            order.Date = DateTime.Now;
            orderService.Add(order);
            _orderId = order.Id;

            MessageBox.Show($"Oluşturulan Sipariş No: {_orderId}");

            int farmerId = Convert.ToInt32(textBoxFarmerId.Text);

            ChooseProduct chooseProduct = new ChooseProduct(farmerId, _orderId);
            chooseProduct.ShowDialog();
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
            var result = MessageBox.Show("Sipariş oluşturulmadı. Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

    }
}
