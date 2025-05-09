﻿using System.Data;
using Dapper;
using OrderSystem2.database;
using OrderSystem2.dto;
using OrderSystem2.model;

public class UserRepository : OrderSystem2.repository.abstracts.IUserRepository
{
    private readonly IDbConnection conn;

    public UserRepository()
    {
        var dbConnectionFactory = new DbConnection();
        conn = dbConnectionFactory.CreateConnection();
    }

    public void Add(User entity)
    {
        string sql = "INSERT INTO [User] ( Name, Surname, Email,Password, Tc, Address, Phone, Status, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@Name, @Surname, @Email, @Password, @Tc, @Address, @Phone, @Status, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt)";
        conn.Execute(sql, entity);
    }

    public void AddUser(OrderSystem2.model.User user)
    {
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        string query = @"INSERT INTO [User] 
                        (Name, Surname, Email, Password, Tc, Address, Phone, Status, CreatedBy, CreatedAt) 
                         VALUES 
                        (@Name, @Surname, @Email, @Password, @Tc, @Address, @Phone, @Status, @CreatedBy, @CreatedAt)";

            conn.Execute(query, user);

    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        return conn.Query<User>($"SELECT * FROM [User] WHERE Status = 1").ToList();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

     public string GetRole(int UserId)
     {
         string query = @"Select RoleName FROM Role JOIN UserRole ON Role.Id = UserRole.RoleId 
                                              JOIN [User] ON [User].Id = UserRole.UserId 
                                              Where [User].Id = @UserId";

         return conn.QueryFirstOrDefault<string>(query, new { UserId });
     }
    public Role GetRoleByUserId(int userId)
    {
        string query = @"
        SELECT R.Id, R.RoleTypeId, R.ZoneId, R.RoleName
        FROM [Role] R
        INNER JOIN UserRole UR ON R.Id = UR.RoleId
        WHERE UR.UserId = @UserId";

        return conn.QueryFirstOrDefault<Role>(query, new { UserId = userId });
    }
    public User GetUserByEmail(string email)
    {
        string query = $"SELECT * FROM [User] WHERE Email = @Email";
        return conn.QueryFirstOrDefault<User>(query, new { Email = email });
    }

    public List<UserDto> GetUserDto()
    {
        return conn.Query<UserDto>(@"SELECT U.Id, U.Name, U.Surname, R.RoleName, U.Email FROM [User] U 
                                                        JOIN UserRole UR ON U.Id=UR.UserId
                                                        JOIN [Role] R ON UR.RoleId=R.Id").ToList();
       
    }

    public bool IsEmailExist(string email)
    {
        string query = "SELECT COUNT(*) FROM [User] WHERE email = @Email";
        int count = conn.ExecuteScalar<int>(query, new { Email = email });
        return count > 0;
    }

    public void Update(User entity, int id)
    {
        throw new NotImplementedException();
    }

    public bool ValidateUser(string email, string password)
    {
        string query = "SELECT Password FROM [User] WHERE Email = @Email";

            var storedHash = conn.QuerySingleOrDefault<string>(query, new { Email = email });

            if (storedHash == null)
                return false;

            return BCrypt.Net.BCrypt.Verify(password, storedHash);
    }

    public bool VerifyPassword(string inputPassword, string storedHash)
    {
        return BCrypt.Net.BCrypt.HashPassword(inputPassword) == storedHash;
    }


}
