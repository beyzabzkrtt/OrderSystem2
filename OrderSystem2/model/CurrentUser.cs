
using OrderSystem2.enums;

namespace OrderSystem2.model
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Zones Zone { get; set; }  
        public RoleTypes RoleType { get; set; }

        public bool HasRole(RoleTypes roleType)
        {
            return RoleType == roleType;
        }

        public bool IsInZone(Zones zone)
        {
            return Zone == zone;
        }

        public bool IsAdmin()
        {
            return RoleType == RoleTypes.Admin;
        }

        public bool IsZoneManager()
        {
            return RoleType == RoleTypes.BolgeSorumlusu;
        }

        public bool IsSalesStaff()
        {
            return RoleType == RoleTypes.SatisPersoneli;
        }
    }
}

