using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class FarmerService : IFarmerService
    {
        private readonly IFarmerRepository _farmerRepository;
        
        public FarmerService(IFarmerRepository farmerRepository)
        {
            _farmerRepository = farmerRepository;   
        }

        public List<Farmer> GetAll()
        {
            return _farmerRepository.GetAll();
        }

        public Farmer GetById(int id)
        {
            return _farmerRepository.GetById(id);
        }

        public void Add(Farmer entity)
        {
            entity.Status = true;
            _farmerRepository.Add(entity); 
        }

        public void Update(Farmer entity,int id)
        {
            entity.UpdatedAt = DateTime.Now;
            _farmerRepository.Update(entity,id);
        }

        public void Delete(int id)
        {
            Farmer f = _farmerRepository.GetById(id);
            f.UpdatedAt = DateTime.Now;
            _farmerRepository.Delete(id);
        }

        public List<Field> GetFields(int id)
        {
            return _farmerRepository.GetFields(id);
        }

        public List<Order> GetOrders(int id)
        {
            return _farmerRepository.GetOrders(id);
        }

        public bool IsFarmerExists(int farmerId)
        {
            return _farmerRepository.IsFarmerExists(farmerId);
        }

        public bool HasAnyOrders(int farmerId)
        {
            return _farmerRepository.HasAnyOrders(farmerId);
        }
    }
}
