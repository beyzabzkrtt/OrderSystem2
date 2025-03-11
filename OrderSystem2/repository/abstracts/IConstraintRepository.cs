using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IConstraintRepository : IGenericRepository<Constraint>
    {
        public Constraint GetMinByProductId(int id);
        public Constraint GetMaxByProductId(int id);
    }
}
