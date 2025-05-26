using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.database;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection conn;

        public CategoryRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
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
                return conn.Query<Category>($"SELECT * FROM {typeof(Category).Name} WHERE Status = 1").ToList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryByFactory(int id)
        {

                string query = "SELECT * FROM Category WHERE FactoryId = @FactoryId";
                return conn.Query<Category>(query, new { FactoryId = id }).ToList();
        }

        public List<Product> GetProducts(int id)
        {
                string query = "SELECT * FROM Product WHERE CategoryId = @CategoryId";
                return conn.Query<Product>(query, new { CategoryId = id }).ToList();
        }

        public void Update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
