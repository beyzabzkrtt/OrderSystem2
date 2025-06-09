using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.entity;
using OrderSystem2.repository.abstracts;

namespace OrderSystem2.service.concretes
{
    public class UserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public string AssignedRole(int UserId,int RoleId)
        {
           return _userRoleRepository.AssignedRole(UserId,RoleId);
        }

        public void Add(UserRole userRole)
        {
            _userRoleRepository.Add(userRole);
        }

        public void Delete(int userId)
        {
            _userRoleRepository.Delete(userId);
        }

    }
}
