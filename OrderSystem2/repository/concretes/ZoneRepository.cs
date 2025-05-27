using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.database;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly IDbConnection conn;

        public ZoneRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(Zone entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Zone> GetAll()
        {
                return conn.Query<Zone>($"SELECT * FROM {typeof(Zone).Name} WHERE Status = 1").ToList();
        }

        public Zone GetById(int id)
        {
            string query = $"SELECT * FROM Zone WHERE Id = @Id";
            return conn.QueryFirstOrDefault<Zone>(query, new { Id = id });
        }

        public List<Zone> GetZoneByFactory(int id)
        {
                string query = "SELECT * FROM Zone WHERE FactoryId = @FactoryId";
                return conn.Query<Zone>(query, new { FactoryId = id }).ToList();
        }

        public string GetZoneNameByFarmerId(int id)
        {
                string query = $"SELECT Zone.Name FROM Zone JOIN Farmer ON Zone.Id = Farmer.ZoneId WHERE Farmer.Id = @FarmerId";
                return conn.QueryFirstOrDefault<string>(query, new { FarmerId = id });
        }

        public void Update(Zone entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
