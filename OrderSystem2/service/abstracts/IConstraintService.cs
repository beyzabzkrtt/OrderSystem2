using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.entity;

namespace OrderSystem2.service.abstracts
{
    public interface IConstraintService : IGenericService<Constraint>
    {
        public List<Constraint> GetListById(int id);
        public Constraint GetMinByProductId(int id);
        public Constraint GetMaxByProductId(int id);
    }
}
