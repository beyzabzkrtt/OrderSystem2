namespace OrderSystem2.model
{
    public class Log
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime Time { get; set; }
        public Boolean Status { get; set; }
        public Object OldValue { get; set; }
        public Object NewValue { get; set; }

    }
}
