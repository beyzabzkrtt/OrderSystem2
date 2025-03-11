namespace OrderSystem2.model
{
    public class Field : BaseModel
    {
        public int FarmerId { get; set; }        
        public double AreaSize   { get; set; }
        public string Address { get; set; }

        public List<Order?> Orders { get; set; }

    }
}
