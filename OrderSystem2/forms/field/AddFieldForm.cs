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

            _fieldRepository = new FieldRepository();
            _fieldService = new FieldService(_fieldRepository);

            _zoneRepository = new ZoneRepository();
            _zoneService = new ZoneService(_zoneRepository);

            _factoryRepository = new FactoryRepository();
            _factoryService = new FactoryService(_factoryRepository);

            AttachPanelDragEvents(panel2);
            LoadCombobox();
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

        private void LoadCombobox()
        {
            var factories = _factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var field = new Field();
            int  farmerId;       
            bool isValidFarmerId = int.TryParse(textBoxFarmerNo.Text.Trim(), out farmerId);
            double areaSize = Convert.ToDouble(textBoxFarmerArea.Text.Trim());

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
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
