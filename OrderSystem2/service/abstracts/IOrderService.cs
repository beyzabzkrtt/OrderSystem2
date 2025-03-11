using OrderSystem2.dto;
using OrderSystem2.model;

namespace OrderSystem2.service.abstracts
{
    public interface IOrderService : IGenericService<Order>
    {
        List<OrderItemDetail> GetOrderItems(int id);
        public List<OrderItem> GetAllOrderItems(int id);
        void UpdateCompleted(int id, bool isCompleted);
        void UpdatePaid(int id, bool isPaid);
    }
}
