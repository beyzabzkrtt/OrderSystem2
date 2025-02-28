using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string _connectionString;

        public CategoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Category>($"SELECT * FROM {typeof(Category).Name} WHERE Status = 1").ToList();
            }
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByFactory(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Category WHERE FactoryId = @FactoryId";
                return conn.Query<Category>(query, new { FactoryId = id }).ToList();
            }
        }

        public void Update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
