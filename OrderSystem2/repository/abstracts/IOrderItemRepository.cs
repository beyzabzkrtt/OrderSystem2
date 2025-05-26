
using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IOrderItemRepository : IGenericRepository<OrderItem>
    {
        public List<OrderItem> GetAllByOrderId(int orderId);
    }
}
