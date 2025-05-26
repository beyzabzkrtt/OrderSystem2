namespace OrderSystem2.entity
{
    public class Product : BaseModel
    {
        public int CategoryId   { get; set; }
        public int UnitId   { get; set; }
        public string Name { get; set; }    
        public double UnitPrice { get; set; }
        public double Stock {  get; set; }
    }
}
