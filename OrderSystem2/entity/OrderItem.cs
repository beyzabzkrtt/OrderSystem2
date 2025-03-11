namespace OrderSystem2.model
{
    public class OrderItem : BaseModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }

    }
}
