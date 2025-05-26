

namespace OrderSystem2.entity
{
    public class Constraint : BaseModel
    {
        public int ProductId { get; set; }
        public string ConstraintType { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

    }
}
