using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IFarmerRepository : IGenericRepository<Farmer>
    {
        
        List<Field?> GetFields(int id);
        List<Order?> GetOrders(int id);

    }
}
