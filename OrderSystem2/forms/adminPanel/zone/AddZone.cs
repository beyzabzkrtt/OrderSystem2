using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem2.entity;
using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;

namespace OrderSystem2.forms.adminPanel.zone
{
    public partial class AddZone : AddBaseForm
    {
        private FactoryRepository factoryRepository;
        private FactoryService factoryService;

        private ZoneRepository zoneRepository;
        private ZoneService zoneService;

        public AddZone()
        {
            InitializeComponent();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();

            factoryRepository = new FactoryRepository();
            factoryService = new FactoryService(factoryRepository);

            zoneRepository = new ZoneRepository();
            zoneService = new ZoneService(zoneRepository);


        }

        public void LoadData()
        {
            var factories = factoryService.GetAll();
            comboBoxFactory.DataSource = factories;
            comboBoxFactory.DisplayMember = "Name";
            comboBoxFactory.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int factoryId = Convert.ToInt32(comboBoxFactory.SelectedValue);
            if (textBoxName != null && factoryId!= null)
            {
                Zone zone = new Zone();
                zone.Name = textBoxName.Text;
                zone.FactoryId = factoryId;
                zoneRepository.Add(zone);
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri girin!");
            }
        }
    }
}
