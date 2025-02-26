using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Order entity)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO [Order] (UserId, FarmerId, FieldId, Date, TotalPrice, isCompleted, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@UserId ,@FarmerId, @FieldId,@Date, @TotalPrice, @isCompleted, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE [Order] SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

                string updateOrderItemsQuery = "UPDATE OrderItem SET Status = 0 WHERE OrderId = @OrderId";
                conn.Execute(updateOrderItemsQuery, new { OrderId = id });

                

            }
        }

        public List<Order> GetAll()
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Order>($"SELECT * FROM [Order] WHERE Status = 1").ToList();
            }
        }

        public Order GetById(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM [Order] WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Order>(query, new { Id = id });
            }
        }

        public List<OrderItem?> GetOrderItems(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<OrderItem>($"SELECT Id,ProductId,UnitId,UnitPrice,Quantity  FROM [OrderItem] WHERE OrderId = @OrderId and Status = 1", new { OrderId = id }).ToList();
            }
        }

        public void Update(Order entity, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompleted(Order entity, int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))

            {
                string query = $"UPDATE [Order] SET isCompleted=@isCompleted WHERE id =@Id";

                var parameters = new DynamicParameters();
                parameters.Add("@iscompleted", entity.isCompleted);

                conn.Execute(query, parameters);
            }
        }
    }
}
