using Microsoft.Data.SqlClient;
using OrderSystem2.repository.abstracts;
using Dapper;
using System.Data;
using Constraint = OrderSystem2.entity.Constraint;
using OrderSystem2.database;

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
            throw new NotImplementedException();
        }

        public Constraint GetById(int id)
        {
            throw new NotImplementedException();
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
    }
}
