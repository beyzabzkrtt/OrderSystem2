using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Add(Product entity)
        {
            entity.Status = true;
           _repository.Add(entity);
            
        }

        public void Delete(int id)
        {
           _repository.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(int id)
        {
           return _repository.GetById(id);
        }

        public string GetCategoryName(int id)
        {
            return _repository.GetCategoryName(id);
        }

        public string GetFactoryName(int id)
        {
            return _repository.GetFactoryName(id);
        }

        public string GetUnitName(int id)
        {
           return _repository.GetUnitName(id);
        }

        public void Update(Product entity, int id)
        {
            entity.UpdatedAt = DateTime.Now;
            _repository.Update(entity, id);
        }

        public void UpdateStock(int id, float stock)
        {
            _repository.UpdateStock(id, stock);
        }
    }
}
