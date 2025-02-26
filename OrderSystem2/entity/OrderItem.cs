namespace OrderSystem2.model
{
    public class OrderItem : BaseModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}
