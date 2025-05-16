using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem2.enums
{
    [Flags]
    public enum RoleTypes
    {
        None = 0,
        SatisPersoneli = 1 << 0,               // 1
        BolgeSorumlusu = SatisPersoneli | 1 << 1, // 1 + 2 = 3
        Admin = BolgeSorumlusu | 1 << 2           // 3 + 4 = 7
    }
}

//bitwise yaklasim ile hiyerarsik yapi