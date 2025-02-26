using Dapper.Contrib.Extensions;

namespace OrderSystem2.model
{
    public class BaseModel
    {
        private bool status;

        [Key]
        public int Id { get; set; }

        public Boolean Status { get => status; set => status = true; }

        public int CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public int UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
