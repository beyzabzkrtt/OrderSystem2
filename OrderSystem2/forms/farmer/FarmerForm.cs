using OrderSystem2.model;
using OrderSystem2.Properties;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms
{
    public partial class FarmerForm : BaseForm
    {
        private FarmerRepository _farmerRepository;
        private FarmerService _farmerService;

        public FarmerForm()
        {
            InitializeComponent();
            AttachPanelDragEvents(panel1);

            _farmerRepository = new FarmerRepository();
            _farmerService = new FarmerService(_farmerRepository);

            LoadFarmer();

            dataGridFarmer.CellDoubleClick += dataGridFarmer_CellDoubleClick;

            panel1.SendToBack();
            pictureBoxBack.BringToFront();
            pictureBoxBack.BringToFront();
            pictureBoxExpand.BringToFront();
            pictureBoxTab.BringToFront();
        }

        public void LoadFarmer()
        {
            var farmers = _farmerService.GetAll();

            dataGridFarmer.AutoGenerateColumns = false;
            dataGridFarmer.Columns.Clear();


            dataGridFarmer.Columns.Add("Id", "Çiftçi No");
            dataGridFarmer.Columns["Id"].DataPropertyName = "Id";

            dataGridFarmer.Columns.Add("Name", "Ad");
            dataGridFarmer.Columns["Name"].DataPropertyName = "Name";

            dataGridFarmer.Columns.Add("Surname", "Soyad");
            dataGridFarmer.Columns["Surname"].DataPropertyName = "Surname";

            dataGridFarmer.Columns.Add("Tc", "Tc");
            dataGridFarmer.Columns["Tc"].DataPropertyName = "Tc";

            dataGridFarmer.Columns.Add("Email", "Email");
            dataGridFarmer.Columns["Email"].DataPropertyName = "Email";

            dataGridFarmer.Columns.Add("Phone", "Telefon");
            dataGridFarmer.Columns["Phone"].DataPropertyName = "Phone";

            dataGridFarmer.Columns.Add("Address", "Adres");
            dataGridFarmer.Columns["Address"].DataPropertyName = "Address";

            dataGridFarmer.DataSource = farmers;
            dataGridFarmer.ReadOnly = true;
        }

        private void dataGridFarmer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedFarmer = (Farmer)dataGridFarmer.Rows[e.RowIndex].DataBoundItem;
                FarmerDetail detailForm = new FarmerDetail(selectedFarmer);
                detailForm.Show();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAddFarmer_Click(object sender, EventArgs e)
        {
            AddFarmerForm addFarmerForm = new AddFarmerForm();
            addFarmerForm.Show();
        }

    }
}
