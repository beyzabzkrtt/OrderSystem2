using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;
using OrderSystem2.database;

namespace OrderSystem2.repository.concretes
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection conn;

        public ProductRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(Product entity)
        {
                string sql = "INSERT INTO Product ( CategoryId, UnitId, Name, UnitPrice, Stock, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@CategoryId, @UnitId,@Name, @UnitPrice, @Stock, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
                conn.Execute(sql, entity);
        }

        public void Delete(int id)
        {
                string query = $"UPDATE Product SET Status = 0 WHERE Id = @Id";
                conn.Execute(query, new { Id = id });
        }

        public List<Product> GetAll()
        {
                return conn.Query<Product>($"SELECT * FROM {typeof(Product).Name} WHERE Status = 1").ToList();
        }

        public Product GetById(int id)
        {
                string query = $"SELECT * FROM {typeof(Product).Name} WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Product>(query, new { Id = id });
        }

        public string GetCategoryName(int id)
        {
               string query = $"SELECT Category.Name FROM Category JOIN Product ON Category.Id = Product.CategoryId WHERE Product.Id = @ProductId";
               return conn.QueryFirstOrDefault<string>(query, new { ProductId = id });
        }

        public string GetFactoryName(int id)
        {
                string query = @"SELECT f.Name FROM Factory f JOIN Category c ON f.Id = c.FactoryId 
                                JOIN Product p ON c.Id = p.CategoryId WHERE p.Id = @ProductId";
                return conn.QueryFirstOrDefault<string>(query, new { ProductId = id });
        }

        public string GetUnitName(int id)
        {
                string query = $"SELECT Unit.Name FROM Unit JOIN Product ON Unit.Id = Product.UnitId WHERE Product.Id = @ProductId";
                return conn.QueryFirstOrDefault<string>(query, new { ProductId = id });
        }

        public bool HasAnyOrders(int id)
        {
            string query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM [OrderItem] WHERE ProductId = @ProductId) THEN 1 ELSE 0 END";
            int count = conn.ExecuteScalar<int>(query, new { ProductId = id });
            return count > 0;
        }

        public bool HasAnyStocks(int id)
        {
            string query = "SELECT CASE WHEN Stock > 0 THEN 1 ELSE 0 END FROM Product WHERE Id = @ProductId;";
            int count = conn.ExecuteScalar<int>(query, new { ProductId = id });
            return count > 0;
        }

        public void Update(Product entity, int id)
        {
                string query = $"UPDATE Product SET Name=@Name, UnitPrice=@UnitPrice, Stock=@Stock WHERE id =@Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Name", entity.Name);
                parameters.Add("@UnitPrice", entity.UnitPrice);
                parameters.Add("@Stock", entity.Stock);
                parameters.Add("@Id", id);

                conn.Execute(query, parameters);
        }

        public void UpdateStock(int id, float stock)
        {
                string query = $"UPDATE Product SET Stock=@Stock WHERE id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Stock",stock);
                parameters.Add("@Id", id);

                conn.Execute(query, parameters);
        }
    }
}
