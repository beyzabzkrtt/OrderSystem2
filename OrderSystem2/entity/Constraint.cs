using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

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
