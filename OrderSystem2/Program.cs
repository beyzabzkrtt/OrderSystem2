using OrderSystem2.model;

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