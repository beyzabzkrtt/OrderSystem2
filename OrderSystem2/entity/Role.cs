namespace OrderSystem2.model
{
    public class Role : BaseModel
    {
        public string RoleName{  get; set; }
        public List<User> Users { get; set; }
    }
}
