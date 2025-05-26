using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using OrderSystem2.database;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.repository.concretes
{
    public class UserRoleRepository : IUserRoleRepository
    {

        private readonly IDbConnection conn;

        public UserRoleRepository()
        {
            var dbConnectionFactory = new DbConnection();
            conn = dbConnectionFactory.CreateConnection();
        }

        public void Add(UserRole entity)
        {
            string sql = "INSERT INTO UserRole (RoleId,UserId, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (RoleId,UserId, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
            conn.Execute(sql, entity);
        }

        public string AssignedRole(UserRole entity)
        {
            // UserId kontrolü
            string userCheckSql = "SELECT COUNT(1) FROM UserRole WHERE UserId = @UserId";
            int userCount = conn.ExecuteScalar<int>(userCheckSql, new { entity.UserId });

            if (userCount > 0)
            {
                return "Bu kullanıcı için yetki bulunmakta.";
            }

            // Eğer RoleId 3 ise, kontrol et
            if (entity.RoleId == 3)
            {
                string roleCheckSql = "SELECT COUNT(1) FROM UserRole WHERE RoleId = 3";
                int roleCount = conn.ExecuteScalar<int>(roleCheckSql);

                if (roleCount > 0)
                {
                    return "Bu rol için kullanıcı bulunmakta.";
                }
            }

            // Kayıt yoksa ekle
            string insertSql = @"
            INSERT INTO UserRole (RoleId, UserId, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) 
            VALUES (@RoleId, @UserId, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
            conn.Execute(insertSql, entity);

            return "Rol atama başarılı.";
        }

        public void Delete(int userId)
        {
            string query = $"DELETE UserRole  WHERE UserId = @userId";
            conn.Execute(query, new { Id = userId });
        }

        public List<UserRole> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserRole GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRole entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
