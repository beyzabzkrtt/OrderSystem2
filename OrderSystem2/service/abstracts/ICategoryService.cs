using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface ICategoryService : IGenericService<Category>
    {
        public List<Category> GetCategoryByFactory(int id);
        public List<Product> GetProducts(int id);
    }
}
