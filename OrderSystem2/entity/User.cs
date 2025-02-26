namespace OrderSystem2.model
{
    public class User : BaseModel
    {
        public int FactoryId { get; set; }
        public int RoleId   { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Tc {  get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Order?> Orders { get; set; }

    }
}
