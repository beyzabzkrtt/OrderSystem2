using OrderSystem2.model;

namespace OrderSystem2.entity
{
    public class UserRole : BaseModel
    {
        public int Id { get; set; } 
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}
