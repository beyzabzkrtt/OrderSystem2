using OrderSystem2.entity;

namespace OrderSystem2.model
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Tc {  get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<UserRole?> Roles { get; set; }

    }
}
