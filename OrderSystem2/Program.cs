using OrderSystem2.forms;
using OrderSystem2.forms.field;
using OrderSystem2.forms.product;

namespace OrderSystem2
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
            
        }
    }

}