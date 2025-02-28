using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class FactoryRepository : IFactoryRepository
    {
        private readonly string _connectionString;

        public FactoryRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void Add(Factory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Factory> GetAll()
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Factory>($"SELECT * FROM {typeof(Factory).Name} WHERE Status = 1").ToList();
            }
        }

        public Factory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Factory entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
