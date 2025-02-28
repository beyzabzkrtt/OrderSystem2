using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class UnitRepository : IUnitRepository
    {
        private readonly string _connectionString;

        public UnitRepository(string connectionString)
        {
            _connectionString = connectionString;
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
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Unit>($"SELECT * FROM {typeof(Unit).Name} WHERE Status = 1").ToList();
            }
        }

        public Unit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Unit entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
