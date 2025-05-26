
using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public List<Category> GetCategoryByFactory(int id);
        public List<Product> GetProducts(int id);
    }
}
