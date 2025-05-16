using System.Text.RegularExpressions;
using OrderSystem2.model;
using TextBox = System.Windows.Forms.TextBox;

namespace OrderSystem2.forms.user
{
    public partial class AddUserForm : AddBaseForm
    {
        private UserRepository repository;

        public AddUserForm()
        {
            InitializeComponent();
            repository = new UserRepository();

            AttachPanelDragEvents(panel1);

            pictureBoxClose.Click += pictureBoxClose_Click;
            buttonSave.Click += buttonSave_Click;

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

            User user = new User();

            try
            {
                user.Name = textBoxName.Text;
                user.Surname = textBoxSurname.Text;
                user.Tc = textBoxTc.Text;
                user.Phone = textBoxPhone.Text;
                user.Email = textBoxEmail.Text;
                user.Password = textBoxPassword.Text;
                user.Address = textBoxAddress.Text;

                repository.AddUser(user);

                MessageBox.Show("Kayıt Eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserForm userForm = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
                if (userForm != null)
                {
                    userForm.LoadData();
                }

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Kullanıcı eklenmedi! Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); ;
            }
        }
    }
}
