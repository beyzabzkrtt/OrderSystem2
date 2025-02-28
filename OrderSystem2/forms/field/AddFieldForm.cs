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
using OrderSystem2.repository.concretes;
using OrderSystem2.service.abstracts;
using OrderSystem2.service.concretes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderSystem2.forms.field
{
    public partial class AddFieldForm : Form
    {
        private string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        private FieldRepository _fieldRepository;
        private FieldService _fieldService;

        private FactoryRepository _factoryRepository;
        private FactoryService _factoryService;

        private ZoneRepository _zoneRepository;
        private ZoneService _zoneService;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        public AddFieldForm()
        {
            InitializeComponent();

            _fieldRepository = new FieldRepository(_connectionString);
            _fieldService = new FieldService(_fieldRepository);

            _zoneRepository = new ZoneRepository(_connectionString);
            _zoneService = new ZoneService(_zoneRepository);

            _factoryRepository = new FactoryRepository(_connectionString);
            _factoryService = new FactoryService(_factoryRepository);

            Bind();
            LoadCombobox();
        }

        private void Bind()
        {
            this.MouseDown += new MouseEventHandler(MouseDownHandler);
            this.MouseMove += new MouseEventHandler(MouseMoveHandler);
            this.MouseUp += new MouseEventHandler(MouseUpHandler);


            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseDown += new MouseEventHandler(MouseDownHandler);
                ctrl.MouseMove += new MouseEventHandler(MouseMoveHandler);
                ctrl.MouseUp += new MouseEventHandler(MouseUpHandler);
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

        private void LoadCombobox()
        {
            var factories = _factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";


            comboBoxFactory.SelectedIndexChanged += comboBoxFactory_SelectedIndexChanged;

            var zones = _zoneService.GetAll();
            comboBoxZone.DataSource = zones;
            comboBoxZone.DisplayMember = "Name";
            comboBoxZone.ValueMember = "Id";

            comboBoxZone.DataSource = null;
            comboBoxZone.Items.Clear();

        }

        private void comboBoxFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadZones();

            if (comboBoxFactory.SelectedIndex != -1)
            {
                labelPlaceholder.Visible = false;
            }
            else
            {
                labelPlaceholder.Visible = true;
            }
        }

        private void LoadZones()
        {
            if (comboBoxFactory.SelectedValue != null)
            {
                int selectedFactoryId;

                if (comboBoxFactory.SelectedValue is int)
                {
                    selectedFactoryId = (int)comboBoxFactory.SelectedValue;
                }
                else
                {
                    return;
                }

                var zones = _zoneRepository.GetZoneByFactory(selectedFactoryId);

                comboBoxZone.DataSource = zones;
                comboBoxZone.DisplayMember = "Name";
                comboBoxZone.ValueMember = "Id";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var field = new Field();
            int  farmerId;       
            bool isValidFarmerId = int.TryParse(textBoxFarmerArea.Text.Trim(), out farmerId);
            double areaSize = Convert.ToDouble(textBoxFarmerNo.Text.Trim());


            field.ZoneId = Convert.ToInt32(comboBoxZone.SelectedValue);
            field.FarmerId = farmerId;
            field.AreaSize = areaSize;

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
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
