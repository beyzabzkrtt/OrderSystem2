﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem2.model;
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
