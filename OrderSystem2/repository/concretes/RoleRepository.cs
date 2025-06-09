
using System.Data;
using Dapper;
using OrderSystem2.database;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IDbConnection conn;

        public RoleRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public int AddRole(int zoneId, int roleTypeId)
        {
            // Önce var mı diye kontrol et
            string checkSql = "SELECT Id FROM [Role] WHERE ZoneId = @zoneId AND RoleTypeId = @roleTypeId";
            int? existingRoleId = conn.ExecuteScalar<int?>(checkSql, new { zoneId, roleTypeId });

            if (existingRoleId.HasValue)
            {
                // Zaten varsa onun ID'sini döndür
                return existingRoleId.Value;
            }

            // Zone ve RoleType bilgilerini al
            var zone = conn.QueryFirstOrDefault<Zone>(
                "SELECT Id, Name FROM Zone WHERE Id = @Id", new { Id = zoneId });

            var roleType = conn.QueryFirstOrDefault<RoleType>(
                "SELECT Id, Name FROM RoleType WHERE Id = @Id", new { Id = roleTypeId });

            if (zone == null || roleType == null)
            {
                throw new Exception("Geçersiz ZoneId veya RoleTypeId");
            }

            // Role adı oluştur
            string roleName = $"{zone.Name} {roleType.Name}";

            // Ekle ve INSERT sonrası ID'yi döndür
            string insertSql = @"
            INSERT INTO Role (ZoneId, RoleTypeId, RoleName, Status)
            VALUES (@ZoneId, @RoleTypeId, @RoleName, @Status);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            int newRoleId = conn.ExecuteScalar<int>(insertSql, new
            {
                ZoneId = zoneId,
                RoleTypeId = roleTypeId,
                RoleName = roleName,
                Status = true
            });

            return newRoleId;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            string query = $"SELECT * [Role] {typeof(Role).Name} WHERE Id = @Id";
            return conn.QueryFirstOrDefault<Role>(query, new { Id = id });
        }

        public void Update(Role entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
