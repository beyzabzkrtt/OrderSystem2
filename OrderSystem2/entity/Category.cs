namespace OrderSystem2.model
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public List<Product?> Products { get; set; }
    }
}
