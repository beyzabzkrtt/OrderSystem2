
using System.Diagnostics;
using System.Windows.Forms;
using OrderSystem2.entity;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.field
{
    public partial class FieldDetail : BaseForm
    {
        private FieldRepository _fieldRepository;
        private FieldService _fieldService;

        private int _fieldId;


        private Dictionary<TextBox, string> initialValues;

        public FieldDetail(int fieldId)
        {
            InitializeComponent();
            _fieldId = fieldId;


            _fieldRepository = new FieldRepository();
            _fieldService = new FieldService(_fieldRepository);

            LoadData();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();

            foreach (var control in Controls.OfType<TextBox>())
            {
                control.TextChanged -= MarkAsChanged;
                control.TextChanged += MarkAsChanged;
            }

            buttonSave.Enabled = false;

            SaveInitialValues();

        }


        private void LoadData()
        {
            Field field = _fieldRepository.GetById(_fieldId);

            textBoxFarmerId.Text = field.FarmerId.ToString();
            textBoxFarmerId.ReadOnly = true;
            textBoxFieldId.Text = _fieldId.ToString();
            textBoxFieldId.ReadOnly = true;
            txtboxArea.Text = field.AreaSize.ToString();
            textBoxAddress.Text = field.Address.ToString();

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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Field field = _fieldRepository.GetById(_fieldId);

            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                field.AreaSize = Convert.ToDouble(txtboxArea.Text);
                field.Address = textBoxAddress.Text;


                _fieldService.Update(field, field.Id);

                MessageBox.Show("Güncelleme başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                LoadData();

                Fieldform fieldform = Application.OpenForms.OfType<Fieldform>().FirstOrDefault();
                if (fieldform != null)
                {
                    fieldform.LoadData();
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
                Field field = _fieldService.GetById(_fieldId);
                bool hasOrder = field.inUsed;

                if (hasOrder)
                {
                    MessageBox.Show("Tarla silinemiyor. Sistemde işlemi bulunmakta.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        _fieldService.Delete(_fieldId);

                        MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Fieldform fieldform = Application.OpenForms.OfType<Fieldform>().FirstOrDefault();
                        if (fieldform != null)
                        {
                            fieldform.LoadData();
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

    }
}
