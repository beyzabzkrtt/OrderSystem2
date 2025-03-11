using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public List<Category> GetCategoryByFactory(int id);
        public List<Product> GetProducts(int id);
    }
}
