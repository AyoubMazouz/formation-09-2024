﻿using formation.Models;

namespace formation.Interfaces;

public interface IUser
{
    Task<User> Save(User user);
    Task<User?> FindByName(string name);
    Task<User?> FindById(int id);
    Task<User> SignIn(string username, string password);
}

