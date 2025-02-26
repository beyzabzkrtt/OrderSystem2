namespace OrderSystem2.model
{
    public class Product : BaseModel
    {
        public int FactoryId { get; set; }
        public int CategoryId   { get; set; }
        public int UnitId   { get; set; }
        public string Name { get; set; }    
        public double Price { get; set; }
        public int Stock {  get; set; }
    }
}
