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
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.user
{
    public partial class UserForm : Form
    {
        private UserRepository repository;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public UserForm()
        {
            InitializeComponent();

            repository = new UserRepository();

            LoadData();

            AttachDragEvents(panel1);
        }

        private void LoadData()
        {
            var users = repository.GetUserDto();

            dataGridUsers.AutoGenerateColumns = false;
            dataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsers.Columns.Clear();


            dataGridUsers.Columns.Add("Id", "Kullanıcı No");
            dataGridUsers.Columns["Id"].DataPropertyName = "Id";

            dataGridUsers.Columns.Add("Name", "Ad");
            dataGridUsers.Columns["Name"].DataPropertyName = "Name";

            dataGridUsers.Columns.Add("Surname", "Soyad");
            dataGridUsers.Columns["Surname"].DataPropertyName = "Surname";

            dataGridUsers.Columns.Add("RoleName", "Yetki");
            dataGridUsers.Columns["RoleName"].DataPropertyName = "RoleName";

            dataGridUsers.Columns.Add("Email", "Email");
            dataGridUsers.Columns["Email"].DataPropertyName = "Email";

            dataGridUsers.DataSource = users;
            dataGridUsers.ReadOnly = true;
        }

        private void AttachDragEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!(ctrl is TextBox))
                {
                    ctrl.MouseDown += MouseDownHandler;
                    ctrl.MouseMove += MouseMoveHandler;
                    ctrl.MouseUp += MouseUpHandler;
                }

                if (ctrl.HasChildren)
                {
                    AttachDragEvents(ctrl);
                }
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxTab_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
