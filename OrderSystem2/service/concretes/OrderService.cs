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

        public Order GetById(int id)
        {
           return _orderRepository.GetById(id);
        }

        public List<OrderItem> GetOrderItems(int id)
        {
            return _orderRepository.GetOrderItems(id);
        }

        public void Update(Order entity, int id)
        {
           _orderRepository.Update(entity, id);
        }
    }
}
