using OrderSystem2.dto;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
           _orderRepository = orderRepository;
        }
        public void Add(Order entity)
        {
            entity.Status = true;
           _orderRepository.Add(entity);
        }

        public void Delete(int id)
        {
           _orderRepository.Delete(id);
        }

        public List<Order> GetAll()
        {
           return _orderRepository.GetAll();
        }

        public List<OrderItem> GetAllOrderItems(int id)
        {
            return _orderRepository.GetAllOrderItems(id);
        }

        public Order GetById(int id)
        {
           return _orderRepository.GetById(id);
        }

        public List<OrderItemDetail> GetOrderItems(int id)
        {
            return _orderRepository.GetOrderItems(id);
        }

        public void Update(Order entity, int id)
        {
           _orderRepository.Update(entity, id);
        }

        public void UpdateCompleted(int id, bool isCompleted)
        {
            _orderRepository.UpdateCompleted(id, isCompleted);
        }

        public void UpdatePaid(int id, bool isPaid)
        {
           _orderRepository.UpdatePaid(id, isPaid);
        }
    }
}
