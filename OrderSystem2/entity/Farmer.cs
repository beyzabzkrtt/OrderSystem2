namespace OrderSystem2.model
{   
    public class Farmer : BaseModel
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tc {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<Field?> Fields { get; set; }
        public List<Order?> Orders { get; set; }

    }
}
