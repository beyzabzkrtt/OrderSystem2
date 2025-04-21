using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public string GetFactoryName(int id);
        public string GetCategoryName(int id);
        public string GetUnitName(int id);
        public void UpdateStock(int id,float stock);
        public bool HasAnyOrders(int id);
        public bool HasAnyStocks(int id);

    }
}
