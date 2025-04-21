using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IFieldService : IGenericService<Field>
    {
        public void SetUsed(int id, bool inUsed);
    }
}
