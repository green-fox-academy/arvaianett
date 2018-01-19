﻿using Reddit.Models;
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

        public UserServices(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
