using System.Data;
using Dapper;
using OrderSystem2.database;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class FarmerRepository : IFarmerRepository
    {

        private readonly IDbConnection conn;

        public FarmerRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }
        public List<Farmer> GetAll()
        {
                return conn.Query<Farmer>($"SELECT * FROM {typeof(Farmer).Name} WHERE Status = 1").ToList();
        }

        public Farmer GetById(int id)
        {
                string query = $"SELECT * FROM {typeof(Farmer).Name} WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Farmer>(query, new { Id = id });
        }

        public void Add(Farmer entity)
        {
                string sql = "INSERT INTO Farmer ( Name, Surname, Tc, Email, Phone, Address, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@Name, @Surname,@Tc, @Email, @Phone, @Address, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
        }

        public void Update(Farmer entity, int id)
        {

                string query = $"UPDATE Farmer SET Name=@Name, Surname=@Surname, Tc=@Tc, Email=@Email, Phone=@Phone, Address=@Address WHERE id =@Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Name", entity.Name);
                parameters.Add("@Surname", entity.Surname);
                parameters.Add("@Tc", entity.Tc);
                parameters.Add("@Email", entity.Email);
                parameters.Add("@Phone", entity.Phone);
                parameters.Add("@Address", entity.Address);
                parameters.Add("@Id", id);

                conn.Execute(query,parameters);
        }

        public void Delete(int id)
        {

                string query = $"UPDATE Farmer SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

                string updateOrdersQuery = "UPDATE [Order] SET Status = 0 WHERE FarmerId = @FarmerId";
                conn.Execute(updateOrdersQuery, new { FarmerId = id });

                string updateFieldsQuery = "UPDATE Field SET Status = 0 WHERE FarmerId = @FarmerId";
                conn.Execute(updateFieldsQuery, new { FarmerId = id });

        }

        public List<Field?> GetFields(int id)
        {

                return conn.Query<Field>($"SELECT *  FROM {typeof(Field).Name} WHERE FarmerId = @FarmerId and Status = 1" , new { FarmerId = id }).ToList();
        }

        public List<Order?> GetOrders(int id)
        {
                return conn.Query<Order>($"SELECT Id,Date,TotalPrice,isCompleted  FROM [{typeof(Order).Name}] WHERE FarmerId = @FarmerId and Status=1", new { FarmerId = id }).ToList();
        }

        public bool IsFarmerExists(int farmerId)
        {
                string query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM Farmer WHERE Id = @Id) THEN 1 ELSE 0 END";
                return conn.ExecuteScalar<bool>(query, new { Id = farmerId });
        }

        public bool HasAnyOrders(int farmerId)
        {
            string query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM [ORder] WHERE FarmerId = @FarmerId) THEN 1 ELSE 0 END";
            int count = conn.ExecuteScalar<int>(query, new { FarmerId = farmerId });
            return count > 0;
        }
    }
}






