using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IFieldRepository : IGenericRepository<Field>
    {      
        public int GetAreaSize(int id);
        public List<Order?> GetOrders(int id);
    }
}
