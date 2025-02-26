using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class FieldRepository : IFieldRepository
    {
        private readonly string _connectionString;

        public FieldRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Field entity)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Field (FarmerId, ZoneId, AreaSize, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@FarmerId ,@ZoneId, @AreaSize, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE Field SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

                string updateOrdersQuery = "UPDATE [Order] SET Status = 0 WHERE FieldId = @FieldId";
                conn.Execute(updateOrdersQuery, new { FieldId = id });

            }
        }

        public List<Order?> GetOrders(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Order>($"SELECT Id,UserId,FieldId,Date,TotalPrice,isCompleted  FROM [{typeof(Order).Name}] WHERE FieldId = @FieldId and Status=1", new { FieldId = id }).ToList();
            }
        }

        public List<Field> GetAll()
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Field>($"SELECT * FROM {typeof(Field).Name} WHERE Status = 1").ToList();
            }
        }

        public Field GetById(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM {typeof(Field).Name} WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Field>(query, new { Id = id });
            }
        }

        public void Update(Field entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
