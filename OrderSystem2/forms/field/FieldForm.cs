using OrderSystem2.model;
using OrderSystem2.Properties;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.field
{
    public partial class Fieldform : BaseForm
    {
        private FieldRepository _fieldRepository;
        private FieldService _fieldService;

        public Fieldform()
        {
            InitializeComponent();

            _fieldRepository = new FieldRepository();
            _fieldService = new FieldService(_fieldRepository);

            LoadData();
            AttachPanelDragEvents(panel2);
            panel2.SendToBack();

        }

        public void LoadData()
        {
            var fields = _fieldService.GetAll();

            dataGridField.AutoGenerateColumns = false;
            dataGridField.Columns.Clear();


            dataGridField.Columns.Add("FarmerId", "Çiftçi No");
            dataGridField.Columns["FarmerId"].DataPropertyName = "FarmerId";

            dataGridField.Columns.Add("AreaSize", "Büyüklük");
            dataGridField.Columns["AreaSize"].DataPropertyName = "AreaSize";

            dataGridField.Columns.Add("Address", "Konum");
            dataGridField.Columns["Address"].DataPropertyName = "Address";

            dataGridField.DataSource = fields;
            dataGridField.ReadOnly = true;
        }      

        private void label2_Click(object sender, EventArgs e)
        {
            AddFieldForm addFieldForm = new AddFieldForm();
            addFieldForm.Show();
        }

        private void dataGridField_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedField = (Field)dataGridField.Rows[e.RowIndex].DataBoundItem;
                FieldDetail detailForm = new FieldDetail(selectedField.Id);
                detailForm.Show();
            }
        }
    }
}
