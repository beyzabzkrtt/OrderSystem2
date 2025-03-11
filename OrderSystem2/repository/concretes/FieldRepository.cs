using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.database;

namespace OrderSystem2.repository.concretes
{
    public class FieldRepository : IFieldRepository
    {
        private readonly IDbConnection conn;

        public FieldRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }
        public void Add(Field entity)
        {
                string sql = "INSERT INTO Field (FarmerId, AreaSize,Address, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@FarmerId, @AreaSize,@Address, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
        }

        public void Delete(int id)
        {
                string query = $"UPDATE Field SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

                string updateOrdersQuery = "UPDATE [Order] SET Status = 0 WHERE FieldId = @FieldId";
                conn.Execute(updateOrdersQuery, new { FieldId = id });

        }

        public List<Order?> GetOrders(int id)
        {
                return conn.Query<Order>($"SELECT Id,UserId,FieldId,Date,TotalPrice,isCompleted  FROM [{typeof(Order).Name}] WHERE FieldId = @FieldId and Status=1", new { FieldId = id }).ToList();
        }

        public List<Field> GetAll()
        {
                return conn.Query<Field>($"SELECT * FROM {typeof(Field).Name} WHERE Status = 1").ToList();
        }

        public Field GetById(int id)
        {
                string query = $"SELECT * FROM {typeof(Field).Name} WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Field>(query, new { Id = id });
        }

        public void Update(Field entity, int id)
        {
            throw new NotImplementedException();
        }

        public int GetAreaSize(int id)
        {
            throw new NotImplementedException();
        }
    }
}
