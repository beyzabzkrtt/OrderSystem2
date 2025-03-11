using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IFarmerService : IGenericService<Farmer>
    {
        public bool HasAnyOrders(int farmerId);
        public bool IsFarmerExists(int farmerId);
        List<Field> GetFields(int id);
        List<Order> GetOrders(int id);
    }
}
