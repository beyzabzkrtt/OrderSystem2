namespace OrderSystem2.entity
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public int FactoryId { get; set; }
        public List<Product?> Products { get; set; }
    }
}
