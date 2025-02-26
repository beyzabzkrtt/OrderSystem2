using OrderSystem2.forms;
using OrderSystem2.forms.field;
using OrderSystem2.forms.product;

namespace OrderSystem2
{
    public partial class MainForm : Form
    {
        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
            pictureBoxClose.Click += pictureBoxClose_Click;
            AttachDragEvents(this);
        }

        private void AttachDragEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!(ctrl is TextBox))  // TextBox'ları hariç tut, yoksa yazı yazarken sürüklenir.
                {
                    ctrl.MouseDown += MouseDownHandler;
                    ctrl.MouseMove += MouseMoveHandler;
                    ctrl.MouseUp += MouseUpHandler;
                }

                // Eğer kontrolün içinde başka kontroller varsa, onlara da ekle
                if (ctrl.HasChildren)
                {
                    AttachDragEvents(ctrl);
                }
            }

            // Form'un kendisini de ekleyelim
            parent.MouseDown += MouseDownHandler;
            parent.MouseMove += MouseMoveHandler;
            parent.MouseUp += MouseUpHandler;
        }

        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
                this.BringToFront();
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
        private void labelFarmerMn_Click(object sender, EventArgs e)
        {
            FarmerForm farmerForm = new FarmerForm();
            farmerForm.Owner = this;
            farmerForm.ShowDialog();
        }

        private void labelOrderMn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Owner = this;
            orderForm.ShowDialog();
        }

        private void labelProductMn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Owner = this;
            productForm.ShowDialog();
        }

        private void labelFieldMn_Click(object sender, EventArgs e)
        {
            Fieldform fieldform = new Fieldform();
            fieldform.Owner = this;
            fieldform.ShowDialog();
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
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm login = new LoginForm();
                login.ShowDialog();
            }
        }
    }
}
