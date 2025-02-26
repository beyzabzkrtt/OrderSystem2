using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IUserRepository
    {
        void AddUser(User user);
        bool ValidateUser(string email, string password);
        string HashPassword(string password);
        bool VerifyPassword(string inputPassword, string storedHash);
    }
}
