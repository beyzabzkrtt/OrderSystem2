

namespace OrderSystem2.forms.liablePanel
{
    public partial class LiablePanel : BaseForm
    {
        public LiablePanel()
        {
            InitializeComponent();
            AttachPanelDragEvents(panel1);
            panel1.SendToBack();
        }
    }
}
