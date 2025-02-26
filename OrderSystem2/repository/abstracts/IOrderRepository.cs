using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        
        void UpdateCompleted(Order entity, int id);
        List<OrderItem?> GetOrderItems(int id);
    }
}
