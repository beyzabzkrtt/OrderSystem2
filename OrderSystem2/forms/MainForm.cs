﻿using OrderSystem2.forms;
using OrderSystem2.forms.field;
using OrderSystem2.forms.order;
using OrderSystem2.forms.product;
using OrderSystem2.forms.user;
using OrderSystem2.Properties;
using OrderSystem2.enums;
using OrderSystem2.forms.adminPanel;
using OrderSystem2.forms.liablePanel;
using OrderSystem2.dto;

namespace OrderSystem2
{
    public partial class MainForm : Form
    {
        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private CurrentUser _user;
        private UserRepository _userRepository = new UserRepository();
        public MainForm(CurrentUser user)
        {
            InitializeComponent();

            _user = user;

            pictureBoxClose.Click += pictureBoxClose_Click;
            AttachPanelDragEvents(panel1);
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

        private void labelFarmerMn_Click(object sender, EventArgs e)
        {
            FarmerForm farmerForm = new FarmerForm();
            farmerForm.Show();
        }

        private void labelOrderMn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void labelProductMn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void labelFieldMn_Click(object sender, EventArgs e)
        {
            Fieldform fieldform = new Fieldform();
            fieldform.Show();
        }

        private void labelMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrderForm makeOrderForm = new MakeOrderForm();
            makeOrderForm.Show();
        }

        private void pictureBoxTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                prevBounds = this.Bounds;

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                pictureBoxExpand.Image = Resources.contract;
                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Bounds = prevBounds;

                pictureBoxExpand.Image = Resources.expand;
                isFullScreen = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (_user.RoleType == RoleTypes.Admin)
            {
                adminPanel adminPanel = new adminPanel();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("Yetki yetersiz!");
            }
        }

        private void buttonLiable_Click(object sender, EventArgs e)
        {
            if((_user.RoleType & RoleTypes.BolgeSorumlusu) == RoleTypes.BolgeSorumlusu) //bitwise kullandiğimiz icin ortak bite sahip mi diye kontrol eder
            {
                LiablePanel liablePanel = new LiablePanel();
                liablePanel.Show();
            }
            else
            {
                MessageBox.Show("Yetki yetersiz!");
            }
        }
    }
}
