using OrderSystem2.dto;
using OrderSystem2.model;

namespace OrderSystem2.repository.abstracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        List<UserDto> GetUserDto();
        void AddUser(User user);
        bool ValidateUser(string email, string password);
        bool VerifyPassword(string inputPassword, string storedHash);
        string GetRole(int id);
        User GetUserByEmail(string email);
        bool IsEmailExist(string email);    
    }
}
