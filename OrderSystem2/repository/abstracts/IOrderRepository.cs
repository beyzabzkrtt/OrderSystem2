
using OrderSystem2.dto;
using OrderSystem2.entity;

namespace OrderSystem2.repository.abstracts
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        List<OrderItem> GetAllOrderItems(int id);
        void UpdateCompleted( int id, bool isCompleted);
        void UpdatePaid( int id, bool isPaid);
        List<OrderItemDetail?> GetOrderItems(int id);
    }
}
