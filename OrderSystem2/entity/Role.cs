using OrderSystem2.enums;

namespace OrderSystem2.entity
{
    public class Role : BaseModel
    {
        public int ZoneId { get; set; }
        public int RoleTypeId { get; set; }
        public string RoleName{  get; set; }

        public List<User> Users { get; set; }

        public RoleTypes RoleTypeEnum => (RoleTypes)RoleTypeId;
        public Zones ZoneEnum => (Zones)ZoneId;
    }
}
