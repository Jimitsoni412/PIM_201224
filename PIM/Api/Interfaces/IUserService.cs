using PIM.Api.Models;

namespace PIM.Api.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
    }
}
