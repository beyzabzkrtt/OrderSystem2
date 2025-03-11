using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.service.abstracts;

namespace OrderSystem2.service.concretes
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _repository;

        public OrderItemService(IOrderItemRepository repository)
        {
            _repository = repository;
        }

        public void Add(OrderItem entity)
        {
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetAllByOrderId(int orderId)
        {
            return _repository.GetAllByOrderId(orderId);
        }

        public OrderItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderItem entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
