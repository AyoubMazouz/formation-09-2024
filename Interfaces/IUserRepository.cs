using formation.Models;

namespace formation.Interfaces;

public interface IUserRepository
{
    Task<User> Save(User user);
    Task<User?> FindByName(string name);
    Task<User?> FindById(int id);
    Task<bool> SignIn(string username, string password);
}

