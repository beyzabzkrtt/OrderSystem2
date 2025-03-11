namespace OrderSystem2.model
{
    public class Role : BaseModel
    {
        public int ZoneId { get; set; }
        public int RoleTypeId { get; set; }
        public string RoleName{  get; set; }

        public List<User> Users { get; set; }
    }
}
