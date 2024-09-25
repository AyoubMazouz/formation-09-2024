using formation.Models;

namespace formation.Interfaces
{
    public interface IUser
    {
        public User Save(User user);
        public User FindBy(int id);
        public User List();
        public User Delete(int id);
    }
}
