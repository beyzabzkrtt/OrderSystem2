using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.database;

namespace OrderSystem2.repository.concretes
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly IDbConnection conn;

        public OrderItemRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(OrderItem entity)
        {
                string sql = "INSERT INTO [OrderItem] ( OrderId, ProductId, Quantity, Price, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@OrderId,@ProductId, @Quantity, @Price,@Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                entity.Status = true;
                conn.Execute(sql, entity);

                string productSql = "SELECT UnitPrice FROM Product WHERE Id = @ProductId";
                var unitPrice = conn.QuerySingleOrDefault<decimal>(productSql, new { ProductId = entity.ProductId });

                if (unitPrice != 0)
                {
                    decimal quantityDecimal = Convert.ToDecimal(entity.Quantity); 
                    decimal totalPriceForItem = unitPrice * quantityDecimal;

                    string updateOrderSql = "UPDATE [Order] SET TotalPrice = TotalPrice + @TotalPrice WHERE Id = @OrderId";
                    conn.Execute(updateOrderSql, new { TotalPrice = totalPriceForItem, OrderId = entity.OrderId });
                }
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
                return conn.Query<OrderItem>(@"SELECT 
                                                p.Name AS ProductName, 
                                                p.UnitPrice, 
                                                oi.Quantity, 
                                                u.Name AS UnitName
                                                FROM OrderItem oi
                                                JOIN Product p ON oi.ProductId = p.Id
                                                JOIN Unit u ON p.UnitId = u.Id
                                                WHERE oi.OrderId = @OrderId", new { OrderId = orderId }).ToList();
            
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
