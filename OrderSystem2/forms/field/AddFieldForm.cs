using System.Globalization;
using OrderSystem2.model;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.field
{
    public partial class AddFieldForm : AddBaseForm
    {
        private FieldRepository _fieldRepository;
        private FieldService _fieldService;

        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        public AddFieldForm()
        {
            InitializeComponent();

            _fieldRepository = new FieldRepository();
            _fieldService = new FieldService(_fieldRepository);

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            AttachPanelDragEvents(panel2);
            pictureBoxClose.Click += pictureBoxClose_Click;
            
        }
       

        private bool AreAllFieldsFilled()
        {
            return Controls.OfType<System.Windows.Forms.TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var field = new Field();
                int farmerId;
                bool isValidFarmerId = int.TryParse(textBoxFarmerNo.Text.Trim(), out farmerId);
                double areaSize = Convert.ToDouble(textBoxFarmerArea.Text.Trim(), CultureInfo.InvariantCulture);

                bool farmerExist = _farmerRepository.IsFarmerExists(farmerId);
                if (!farmerExist)
                {
                    MessageBox.Show("Girilen çiftçi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                field.FarmerId = farmerId;
                field.AreaSize = areaSize;
                field.Address = textBoxAddress.Text;

                try
                {
                    _fieldService.Add(field);
                    MessageBox.Show("Tarla başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Fieldform fieldform = Application.OpenForms.OfType<Fieldform>().FirstOrDefault();
                    if (fieldform != null)
                    {
                        fieldform.LoadData();
                    }
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Tarla eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli değer girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void pictureBoxClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tarla eklenmedi! Formu kapatmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); ;
            }
        }
    }
}
