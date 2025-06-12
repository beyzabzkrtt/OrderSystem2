using System.Data;
using Dapper;
using OrderSystem2.database;
using OrderSystem2.dto;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class UserRepository : IUserRepository
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

    public void AddUser(User user)
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
        string query = $"DELETE [User]  WHERE Id = @id";
        conn.Execute(query, new { Id = id });
    }

    public List<User> GetAll()
    {
        return conn.Query<User>($"SELECT * FROM [User] WHERE Status = 1").ToList();
    }

    public User GetById(int id)
    {
        string query = $"SELECT * FROM [User] WHERE Id = @Id";
        return conn.QueryFirstOrDefault<User>(query, new { Id = id });
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
        return conn.Query<UserDto>(
            @"SELECT U.Id, U.Name, U.Surname, R.RoleName, U.Email 
          FROM [User] U 
          LEFT JOIN UserRole UR ON U.Id = UR.UserId
          LEFT JOIN [Role] R ON UR.RoleId = R.Id").ToList();
    }

    public bool HasRole(int userId)
    {
        string sql = "SELECT COUNT(1) FROM UserRole WHERE UserId = @userId";

        int count = conn.ExecuteScalar<int>(sql, new { UserId = userId });

        return count > 0;
    }

    public bool IsEmailExist(string email)
    {
        string query = "SELECT COUNT(*) FROM [User] WHERE email = @Email";
        int count = conn.ExecuteScalar<int>(query, new { Email = email });
        return count > 0;
    }

    public void Update(User entity, int id)
    {

        string query = $"UPDATE [User] SET Name=@Name, Surname=@Surname, Tc=@Tc, Email=@Email, Phone=@Phone, Address=@Address WHERE id =@Id";

        var parameters = new DynamicParameters();
        parameters.Add("@Name", entity.Name);
        parameters.Add("@Surname", entity.Surname);
        parameters.Add("@Tc", entity.Tc);
        parameters.Add("@Email", entity.Email);
        parameters.Add("@Phone", entity.Phone);
        parameters.Add("@Address", entity.Address);
        parameters.Add("@Id", id);

        conn.Execute(query, parameters);
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
