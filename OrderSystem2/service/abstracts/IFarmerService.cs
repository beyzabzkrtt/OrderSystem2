using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IFarmerService : IGenericService<Farmer>
    {
        List<Field> GetFields(int id);
        List<Order> GetOrders(int id);
    }
}
