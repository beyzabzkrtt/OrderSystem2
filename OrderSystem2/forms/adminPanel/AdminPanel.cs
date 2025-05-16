using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem2.forms.user;

namespace OrderSystem2.forms.adminPanel
{
    public partial class adminPanel : BaseForm
    {
        public adminPanel()
        {
            InitializeComponent();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();
        }

        private void labelMakeOrder_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
    }
}
