namespace OrderSystem2.model
{
    public class Factory : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Zone?> Zones { get; set; }
        public List<User?> Users { get; set; }
        public List<Product?> Products { get; set; }

    }
}
