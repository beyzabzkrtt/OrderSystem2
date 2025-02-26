using OrderSystem2.repository.concretes;
using OrderSystem2.service.concretes;
using OrderSystem2.forms;
using OrderSystem2.model;
using OrderSystem2.forms.field;

namespace OrderSystem2
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";
            UserRepository userRepository = new UserRepository(_connectionString);

           /* User admin = new User();
            admin.FactoryId = 1;
            admin.RoleId = 1;
            admin.Name = "ozan";
            admin.Email = "ozan@mail.com";
            admin.Password = "ozan123";
            userRepository.AddUser(admin);*/


            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            
        }
    }

}