using Dapper;
using System.Data;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.dto;
using OrderSystem2.database;

namespace OrderSystem2.repository.concretes
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDbConnection conn;

        public OrderRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }
        public void Add(Order entity)
        {        
                string sql = @"
            INSERT INTO [Order] 
            (FarmerId, Date, TotalPrice, isPaid,isCompleted, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) 
            VALUES 
            (@FarmerId, @Date, @TotalPrice,@isPaid, @isCompleted, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt);

            SELECT CAST(SCOPE_IDENTITY() as int);";

                entity.Id = conn.ExecuteScalar<int>(sql, entity);
            
        }

        public void Delete(int id)
        {

                string query = $"UPDATE [Order] SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

                string updateOrderItemsQuery = "UPDATE OrderItem SET Status = 0 WHERE OrderId = @OrderId";
                conn.Execute(updateOrderItemsQuery, new { OrderId = id });

            
        }

        public List<Order> GetAll()
        {
                return conn.Query<Order>($"SELECT * FROM [Order] WHERE Status = 1").ToList();
        }

        public List<OrderItem> GetAllOrderItems(int id)
        {
                var query = @"Select * from OrderItem Where  OrderId = @OrderId AND Status = 1";

                return conn.Query<OrderItem>(query, new { OrderId = id }).ToList();
        }

        public Order GetById(int id)
        {
                string query = $"SELECT * FROM [Order] WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Order>(query, new { Id = id });
        }

        public List<OrderItemDetail?> GetOrderItems(int id)
        {
                var query = @"
                        SELECT 
                        p.Name AS ProductName, 
                        oi.Quantity, 
                        p.UnitPrice,
                        oi.Price,
                        u.Name AS UnitName 
                    FROM [OrderItem] oi
                    JOIN Product p ON oi.ProductId = p.Id
                    JOIN [Order] o ON oi.OrderId = o.Id
                    JOIN Unit u ON p.UnitId = u.Id
                    WHERE oi.OrderId = @OrderId AND oi.Status = 1;";

                return conn.Query<OrderItemDetail>(query, new { OrderId = id }).ToList();
        }

        public void Update(Order entity, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompleted(int id, bool isCompleted)
        {
                string query = $"UPDATE [Order] SET isCompleted = @isCompleted WHERE id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@isCompleted", isCompleted);
                parameters.Add("@Id", id);

                conn.Execute(query, parameters);
        }

        public void UpdatePaid(int id, bool isPaid)
        {
                string query = $"UPDATE [Order] SET isPaid = @isPaid WHERE id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@isPaid", isPaid);
                parameters.Add("@Id", id);

                conn.Execute(query, parameters);
        }
    }
}
