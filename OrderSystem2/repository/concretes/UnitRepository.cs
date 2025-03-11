using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.database;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class UnitRepository : IUnitRepository
    {
        private readonly IDbConnection conn;

        public UnitRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(Unit entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Unit> GetAll()
        {
                return conn.Query<Unit>($"SELECT * FROM {typeof(Unit).Name} WHERE Status = 1").ToList();
        }

        public Unit GetById(int id)
        {
                string query = $"SELECT * FROM Unit WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Unit>(query, new { Id = id });
        }

        public void Update(Unit entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
