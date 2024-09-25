﻿using formation.Interfaces;
using formation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace formation.Services
{
    public class UserServices
    {
        private readonly IUser _userRepository;

        public UserServices(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Save(User user)
        {
            return await _userRepository.Save(user);
        }

        public async Task<User?> FindById(int id)
        {
            return await _userRepository.FindById(id);
        }

        public async Task<User?> FindByName(string name)
        {
            return await _userRepository.FindByName(name);
        }

        public async Task<User?> SignIn(string username, string password)
        {
            return await _userRepository.SignIn(username, password);
        }
    }
}
