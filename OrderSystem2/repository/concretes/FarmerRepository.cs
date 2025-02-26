using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class FarmerRepository : IFarmerRepository
    {
       //private readonly IDbConnection _dbConnection;
        private readonly string _connectionString;

       /*  public FarmerRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;

        } */

        public FarmerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Farmer> GetAll()
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Farmer>($"SELECT * FROM {typeof(Farmer).Name} WHERE Status = 1").ToList();
            }
        }

        public Farmer GetById(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM {typeof(Farmer).Name} WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Farmer>(query, new { Id = id });
            }
        }

        public void Add(Farmer entity)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Farmer (ZoneId, Name, Surname, Tc, Email, Phone, Address, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@ZoneId ,@Name, @Surname,@Tc, @Email, @Phone, @Address, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
            }
        }

        public void Update(Farmer entity, int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))

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
        }

        public void Delete(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE Farmer SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

                string updateOrdersQuery = "UPDATE [Order] SET Status = 0 WHERE FarmerId = @FarmerId";
                conn.Execute(updateOrdersQuery, new { FarmerId = id });

                string updateFieldsQuery = "UPDATE Field SET Status = 0 WHERE FarmerId = @FarmerId";
                conn.Execute(updateFieldsQuery, new { FarmerId = id });

            }
        }

        public List<Field?> GetFields(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            { 
                return conn.Query<Field>($"SELECT Id,ZoneId,AreaSize  FROM {typeof(Field).Name} WHERE FarmerId = @FarmerId and Status = 1" , new { FarmerId = id }).ToList();
            }
        }

        public List<Order?> GetOrders(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Order>($"SELECT Id,UserId,FieldId,Date,TotalPrice,isCompleted  FROM [{typeof(Order).Name}] WHERE FarmerId = @FarmerId and Status=1", new { FarmerId = id }).ToList();
            }
        }
    }
}






