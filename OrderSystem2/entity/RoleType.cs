using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.entity
{
    public class RoleType : BaseModel
    {
        public int FactoryId { get; set; }
        public string Name { get; set; }
    }
}
