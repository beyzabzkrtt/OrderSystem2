
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.service.concretes
{
    public class UserService
    {

        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
           this.userRepository = userRepository;
        }

        public void AddUser(User user)
        { 
            user.Status = true;
            userRepository.AddUser(user);
           
        }

        public bool HasRole(int userId)
        {
            return userRepository.HasRole(userId);
        }

        public void Delete(int id)
        {
            userRepository.Delete(id);
        }

        public String GetRole(int id)
        {
            return userRepository.GetRole(id);
        }

        public void Update(User user , int id)
        {
            userRepository.Update(user , id);
        }

        public bool ValidateUser(string email, string password)
        {
           return userRepository.ValidateUser(email, password);
        }

        public bool VerifyPassword(string inputPassword, string storedHash)
        {
            return (userRepository.VerifyPassword(inputPassword, storedHash));
        }

    }
}
