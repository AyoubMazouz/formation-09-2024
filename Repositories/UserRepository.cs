using formation.Interfaces;
using formation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace formation.Repositories;

public class UserRepository : IUser
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> Save(User user)
    {
        var newUser = await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return newUser.Entity;
    }

    public async Task<User?> FindById(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<User?> FindByName(string name)
    {
        return await _context.Users.FirstOrDefaultAsync(i => i.UserName == name);
    }

    public async Task<User?> SignIn(string username, string password)
    {
        //User? user = await FindByName(username);
        //if (user == null)
        //{
            
        //}
    }
}

