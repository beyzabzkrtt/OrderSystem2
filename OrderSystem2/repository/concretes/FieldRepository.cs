using Dapper;
using System.Data;
using OrderSystem2.entity;
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
                string sql = "INSERT INTO Field (FarmerId, AreaSize,Address,inUsed, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@FarmerId, @AreaSize,@Address, @inUsed, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
        }

        public void Delete(int id)
        {
                string query = $"UPDATE Field SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

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
            string query = $"UPDATE Field SET AreaSize=@AreaSize, Address=@Address WHERE id =@Id";

            var parameters = new DynamicParameters();
            parameters.Add("@AreaSize", entity.AreaSize);
            parameters.Add("@Address", entity.Address);
            parameters.Add("@Id", id);

            conn.Execute(query, parameters);
        }

        public void SetUsed(int fieldId, bool inUsed)
        {
                string query = "UPDATE Field SET inUsed = @InUsed WHERE Id = @FieldId";
                conn.Execute(query, new { InUsed = inUsed, FieldId = fieldId });
        }
    }
}
