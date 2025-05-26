namespace OrderSystem2.entity
{
    public class Unit : BaseModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
