using System.Collections.Generic;
using System.Linq;
using PIM.Api.Data;
using PIM.Api.Interfaces;
using PIM.Api.Models;

namespace PIM.Api.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public User Authenticate(string username, string password)
        {
            // This is a simplified example; implement proper hashing and verification in production.
            var user = _context.Users.SingleOrDefault(x => x.Username == username && x.PasswordHash == password);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}