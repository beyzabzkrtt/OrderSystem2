using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Product entity)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Product (FactoryId, CategoryId, UnitId, Name, Price, Stock, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@FactoryId ,@CategoryId, @UnitId,@Name, @Price, @Stock, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE Product SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });

            }
        }

        public List<Product> GetAll()
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Product>($"SELECT * FROM {typeof(Product).Name} WHERE Status = 1").ToList();
            }
        }

        public Product GetById(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM {typeof(Product).Name} WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Product>(query, new { Id = id });
            }
        }

        public string GetCategoryName(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT Category.Name FROM Category JOIN Product ON Category.Id = Product.CategoryId WHERE Product.Id = @ProductId";
                return conn.QueryFirstOrDefault<string>(query, new { ProductId = id });
            }
        }

        public string GetFactoryName(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT Factory.Name FROM Factory JOIN Product ON Factory.Id = Product.FactoryId WHERE Product.Id = @ProductId";
                return conn.QueryFirstOrDefault<string>(query, new { ProductId = id });
            }
        }

        public string GetUnitName(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT Unit.Name FROM Unit JOIN Product ON Unit.Id = Product.UnitId WHERE Product.Id = @ProductId";
                return conn.QueryFirstOrDefault<string>(query, new { ProductId = id });
            }
        }

        public void Update(Product entity, int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))

            {
                string query = $"UPDATE Product SET Name=@Name, Price=@Price, Stock=@Stock WHERE id =@Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Name", entity.Name);
                parameters.Add("@Price", entity.Price);
                parameters.Add("@Stock", entity.Stock);
                parameters.Add("@Id", id);

                conn.Execute(query, parameters);
            }
        }
    }
}
