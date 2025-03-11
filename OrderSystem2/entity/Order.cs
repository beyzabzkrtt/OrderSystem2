namespace OrderSystem2.model
{
    public class Order : BaseModel
    {
        public int FarmerId { get; set; }
        public DateTime Date { get; set; }
        public float TotalPrice { get; set; }
        public Boolean isPaid { get; set; }
        public Boolean isCompleted { get; set; }

        public  List<OrderItem?> OrderItems { get; set; }

    }
}
