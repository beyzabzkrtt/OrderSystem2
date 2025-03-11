using System.Diagnostics;
using System.Text.RegularExpressions;
using OrderSystem2.forms.farmer;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class FarmerDetail : Form
    {
        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;


        private Farmer _farmer;

        private bool isFullScreen = false;
        private Rectangle prevBounds;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        private Dictionary<TextBox, string> initialValues;

        public FarmerDetail(Farmer farmer)
        {
            InitializeComponent();
            _farmer = farmer;

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            LoadData();
            AttachPanelDragEvents(panel2);

            buttonSave.Click -= buttonSave_Click;
            buttonSave.Click += buttonSave_Click;

            buttonDelete.Click -= buttonDelete_Click;
            buttonDelete.Click += buttonDelete_Click;

            buttonSave.Enabled = false;

            foreach (var control in Controls.OfType<TextBox>())
            {
                control.TextChanged -= MarkAsChanged;
                control.TextChanged += MarkAsChanged;
            }

            SaveInitialValues();


        }

        private void LoadData()
        {
            textBoxFarmerID.Text = _farmer.Id.ToString();
            textBoxFarmerID.ReadOnly = true;
            textBoxName.Text = _farmer.Name;
            textBoxSurname.Text = _farmer.Surname;
            textBoxPhone.Text = _farmer.Phone;
            textBoxEmail.Text = _farmer.Email;
            textBoxAddress.Text = _farmer.Address;
            textBoxTc.Text = _farmer.Tc;

        }

        private void SaveInitialValues()
        {
            initialValues = Controls.OfType<TextBox>()
                   .ToDictionary(tb => tb, tb => tb.Text);
            Debug.WriteLine("Initial Values Saved: ");

            foreach (var control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    Debug.WriteLine($"Saving: {textBox.Name} = {textBox.Text}");
                }
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

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(\+90|90)?(5\d{9}|[2-9]\d{9})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxTc.Text.Length != 11)
            {
                MessageBox.Show("Lütfen Tc'yi doğru giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidPhoneNumber(textBoxPhone.Text))
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası girin! (Örn: 5321234567 veya 2123456789)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _farmer.Name = textBoxName.Text;
                _farmer.Surname = textBoxSurname.Text;
                _farmer.Tc = textBoxTc.Text;
                _farmer.Phone = textBoxPhone.Text;
                _farmer.Email = textBoxEmail.Text;
                _farmer.Address = textBoxAddress.Text;

                _farmerService.Update(_farmer, _farmer.Id);

                MessageBox.Show("Güncelleme başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Enabled = false;

                LoadData();

                FarmerForm farmerForm = Application.OpenForms.OfType<FarmerForm>().FirstOrDefault();
                if (farmerForm != null)
                {
                    farmerForm.LoadFarmer();
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
                bool hasAnyOrder = _farmerService.HasAnyOrders(_farmer.Id);
                if (hasAnyOrder)
                {
                    MessageBox.Show("Çiftçi silinemiyor. Sistemde işlemi bulunmakta.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        _farmerService.Delete(_farmer.Id);

                        MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FarmerForm farmerForm = Application.OpenForms.OfType<FarmerForm>().FirstOrDefault();
                        if (farmerForm != null)
                        {
                            farmerForm.LoadFarmer();
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            FarmerForm farmerForm = Application.OpenForms.OfType<FarmerForm>().FirstOrDefault();
            if (farmerForm != null)
            {
                farmerForm.LoadFarmer();
            }
            this.Close();
        }

        private void buttonShowField_Click(object sender, EventArgs e)
        {
            FarmerFieldForm farmerFieldForm = new FarmerFieldForm(_farmer.Id);
            farmerFieldForm.Show();
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            FarmerOrderForm farmerOrderForm = new FarmerOrderForm(_farmer.Id);
            farmerOrderForm.Show();
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
