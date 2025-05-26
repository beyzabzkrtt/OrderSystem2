
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class FactoryService : IFactoryService
    {
        private readonly IFactoryRepository _factoryRepository;

        public FactoryService(IFactoryRepository factoryRepository)
        {
            _factoryRepository = factoryRepository;
        }

        public void Add(Factory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Factory> GetAll()
        {
            return _factoryRepository.GetAll();
        }

        public Factory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories(int factoryId)
        {
            return _factoryRepository.GetCategories(factoryId);
        }

        public void Update(Factory entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
