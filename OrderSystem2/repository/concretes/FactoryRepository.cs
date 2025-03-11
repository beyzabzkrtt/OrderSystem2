using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.database;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class FactoryRepository : IFactoryRepository
    {
        private readonly IDbConnection conn;

        public FactoryRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
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
                return conn.Query<Factory>($"SELECT * FROM {typeof(Factory).Name} WHERE Status = 1").ToList();
        }

        public Factory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories(int factoryId)
        {
                string query = "SELECT * FROM Category WHERE FactoryId = @FactoryId";
                return conn.Query<Category>(query, new { FactoryId = factoryId }).ToList();
        }

        public void Update(Factory entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
