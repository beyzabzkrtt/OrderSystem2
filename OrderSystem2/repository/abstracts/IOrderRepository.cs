using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.dto;
using OrderSystem2.model;

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
