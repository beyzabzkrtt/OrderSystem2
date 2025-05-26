using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IFactoryRepository : IGenericRepository<Factory>
    {
        public List<Category> GetCategories(int factoryId);
       
    }
}
