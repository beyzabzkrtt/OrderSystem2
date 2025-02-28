using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly string _connectionString;

        public ZoneRepository(string connectionString)
        {
            _connectionString = connectionString;
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
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<Zone>($"SELECT * FROM {typeof(Zone).Name} WHERE Status = 1").ToList();
            }
        }

        public Zone GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Zone> GetZoneByFactory(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Zone WHERE FactoryId = @FactoryId";
                return conn.Query<Zone>(query, new { FactoryId = id }).ToList();
            }
        }

        public string GetZoneNameByFarmerId(int id)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"SELECT Zone.Name FROM Zone JOIN Farmer ON Zone.Id = Farmer.ZoneId WHERE Farmer.Id = @FarmerId";
                return conn.QueryFirstOrDefault<string>(query, new { FarmerId = id });
            }
        }

        public void Update(Zone entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
