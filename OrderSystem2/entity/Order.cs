namespace OrderSystem2.model
{
    public class Order : BaseModel
    {
        public int UserId { get; set; }
        public int FarmerId { get; set; }
        public int FieldId { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public Boolean isCompleted { get; set; }

        public  List<OrderItem?> OrderItems { get; set; }

    }
}
