using System.Text.RegularExpressions;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class AddFarmerForm : AddBaseForm
    {

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        private ZoneRepository _zoneRepository;
        private ZoneService _zoneService;

        private FactoryRepository _factoryRepository;
        private FactoryService _factoryService;

        public AddFarmerForm()
        {
            InitializeComponent();

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            _zoneRepository = new ZoneRepository();
            _zoneService = new ZoneService(_zoneRepository);

            _factoryRepository = new FactoryRepository();
            _factoryService = new FactoryService(_factoryRepository);

            AttachPanelDragEvents(panel2);
            pictureBoxClose.Click += pictureBoxClose_Click;

        }
        
        private bool AreAllFieldsFilled()
        {
            return Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
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
                MessageBox.Show("Lütfen geçerli bir TC No giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            var farmer = new Farmer();

            farmer.Name = textBoxName.Text.Trim();
            farmer.Surname = textBoxSurname.Text.Trim();
            farmer.Tc = textBoxTc.Text.Trim();
            farmer.Email = textBoxEmail.Text.Trim();
            farmer.Address = textBoxAddress.Text.Trim();
            farmer.Phone = textBoxPhone.Text.Trim();

            try
            {
                _farmerService.Add(farmer);
                MessageBox.Show("Çiftçi başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        protected override void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çiftçi eklenmedi! Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); ;
            }
        }

    }
}
