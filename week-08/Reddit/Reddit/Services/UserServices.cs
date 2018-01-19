using Reddit.Entities;
using Reddit.Models;
using Reddit.Repositories;
using Reddit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class UserServices
    {
        private UserRepository userRepository;
        private HomeContext homeContext;

        public UserServices(UserRepository userRepository, HomeContext homeContext)
        {
            this.userRepository = userRepository;
            this.homeContext = homeContext;
        }

        public bool UserStatus(string username)
        {
            return userRepository.UserStatus(username);
        }
        public void AddUser(string username)
        {
            userRepository.AddUser(username);
        }
    }
}
