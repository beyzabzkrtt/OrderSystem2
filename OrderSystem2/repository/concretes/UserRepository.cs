using Microsoft.Data.SqlClient;
using Dapper;
using OrderSystem2.model;
using OrderSystem2.repository.abstracts;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;

    public UserRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddUser(User user)
    {
        user.Password = HashPassword(user.Password);

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = @"INSERT INTO [User] 
                            (FactoryId, RoleID, Name, Surname, Email, Password, Tc, Address, Phone, Status, CreatedBy, CreatedAt) 
                             VALUES 
                            (@FactoryId, @RoleID, @Name, @Surname, @Email, @Password, @Tc, @Address, @Phone, @Status, @CreatedBy, @CreatedAt)";

            connection.Execute(query, user);
            connection.Dispose();
            connection.Close();
        }
    }

    public bool ValidateUser(string email, string password)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Password FROM [User] WHERE Email = @Email";  
            var storedHash = connection.QuerySingleOrDefault<string>(query, new { Email = email });

            if (storedHash == null)
                return false; 

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHash);

            return isPasswordValid;
        }
    }

    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);

    }

    public bool VerifyPassword(string inputPassword, string storedHash)
    {
        return HashPassword(inputPassword) == storedHash;
    }
}
