using Microsoft.Data.SqlClient;
using OrderSystem2.repository.abstracts;
using Dapper;
using System.Data;
using Constraint = OrderSystem2.entity.Constraint;
using OrderSystem2.database;
using OrderSystem2.model;

namespace OrderSystem2.repository.concretes
{
    public class ConstraintRepository : IConstraintRepository
    {
        private readonly IDbConnection conn;

        public ConstraintRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(Constraint entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Constraint> GetAll()
        {
            return conn.Query<Constraint>($"SELECT * FROM [Constraint] WHERE Status = 1").ToList();
        }

        public List<Constraint> GetListById(int id)
        {

            string query = $"SELECT * FROM [Constraint] WHERE ProductId = @ProductId";
            return (List<Constraint>)conn.Query<Constraint>(query, new { ProductId = id });
        }

        public Constraint GetMaxByProductId(int id)
        {
                string query = $"SELECT * FROM [Constraint] WHERE ProductId = @ProductId AND ConstraintType = 'MaxAmount'";
                return conn.QueryFirstOrDefault<Constraint>(query, new { ProductId = id });
        }

        public Constraint GetMinByProductId(int id)
        {
                string query = $"SELECT * FROM [Constraint] WHERE ProductId = @ProductId AND ConstraintType = 'MinFieldArea'";
                return conn.QueryFirstOrDefault<Constraint>(query, new { ProductId = id });
        }

        public void Update(Constraint entity, int id)
        {
            throw new NotImplementedException();
        }

        Constraint IGenericRepository<Constraint>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
