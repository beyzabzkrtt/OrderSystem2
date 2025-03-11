namespace OrderSystem2.model
{
    public class Product : BaseModel
    {
        public int CategoryId   { get; set; }
        public int UnitId   { get; set; }
        public string Name { get; set; }    
        public double UnitPrice { get; set; }
        public float Stock {  get; set; }
    }
}
