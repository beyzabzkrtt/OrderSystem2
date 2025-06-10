

using OrderSystem2.service.concretes;
using OrderSystem2.entity;
using System.Diagnostics;
using System.Text.RegularExpressions;
using OrderSystem2.forms.user;

namespace OrderSystem2.forms.adminPanel.user
{
    public partial class UserDetailForm : BaseForm
    {
        private UserRepository _userRepository;
        private UserService _userService;

        private User _user;

        private Dictionary<TextBox, string> initialValues;

        public UserDetailForm(User user)
        {
            _user = user;

            _userRepository = new UserRepository();
            _userService = new UserService(_userRepository);

            InitializeComponent();
            LoadData();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();

            buttonSave.Enabled = false;
            buttonSave.Click += buttonSave_Click;
            buttonRoles.Click += buttonRoles_Click; 

            foreach (var control in Controls.OfType<TextBox>())
            {
                control.TextChanged -= MarkAsChanged;
                control.TextChanged += MarkAsChanged;
            }

            SaveInitialValues();

            buttonDelete.Click += buttonDelete_Click;

        }


        public void LoadData()
        {
            textBoxUserID.Text = _user.Id.ToString();
            textBoxUserID.ReadOnly = true;
            textBoxName.Text = _user.Name;
            textBoxSurname.Text = _user.Surname;
            textBoxEmail.Text = _user.Email;
            textBoxTc.Text = _user.Tc;
            textBoxPhone.Text = _user.Phone;
            textBoxAddress.Text = _user.Address;
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
                _user.Name = textBoxName.Text;
                _user.Surname = textBoxSurname.Text;
                _user.Tc = textBoxTc.Text;
                _user.Phone = textBoxPhone.Text;
                _user.Email = textBoxEmail.Text;
                _user.Address = textBoxAddress.Text;

                _userService.Update(_user, _user.Id);

                MessageBox.Show("Güncelleme başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Enabled = false;

                LoadData();

                UserForm userForm = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
                if (userForm != null)
                {
                    userForm.LoadData();
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
                if (_userService.HasRole(_user.Id))
                {
                    try
                    {
                        _userService.Delete(_user.Id);

                        MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserForm userForm = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
                        if (userForm != null)
                        {
                            userForm.LoadData();
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcının yetkisi bulunmakta. Lütfen önce yetkisini kaldırın.");
                }

            }

        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            UserRoleForm userRoleForm = new UserRoleForm(_user);
            userRoleForm.ShowDialog();
        }
    }
}
