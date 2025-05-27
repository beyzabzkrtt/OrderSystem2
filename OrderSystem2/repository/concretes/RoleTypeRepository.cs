using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OrderSystem2.database;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class RoleTypeRepository : IRoleTypeRepository
    {
        private readonly IDbConnection conn;

        public RoleTypeRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }
        public void Add(RoleType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<RoleType> GetAll()
        {
            return conn.Query<RoleType>($"SELECT * FROM {typeof(RoleType).Name} WHERE Status = 1").ToList();
        }
        

        public RoleType GetById(int id)
        {
            string query = $"SELECT * FROM RoleType WHERE Id = @Id";
            return conn.QueryFirstOrDefault<RoleType>(query, new { Id = id });
        }

        public void Update(RoleType entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
