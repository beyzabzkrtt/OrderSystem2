namespace OrderSystem2.model
{
    public class Field : BaseModel
    {
        public int FarmerId { get; set; }
        public int ZoneId   { get; set; }
        public double AreaSize   { get; set; }

        public List<LocationDetail?> LocationDetails { get; set; }
        public List<Order?> Orders { get; set; }

    }
}
