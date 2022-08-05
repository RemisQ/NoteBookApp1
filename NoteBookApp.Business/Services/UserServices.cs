using NoteBookApp.Repository.ContextDb;
using NoteBookApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp.Business.Services
{
    public class UserServices
    {
        private NoteBookDbContext _context;
        public UserServices(NoteBookDbContext dbContext)
        {
            _context = dbContext;
        }
        public void CreateUser(string firstName, string lastName, string userName, string password)
        {
            User user = new(firstName, lastName, userName, password);
            _context.Add(user);
            _context.SaveChanges();
        }
        public User FindUserById(Guid userId)
        {
            var user = _context.Users.
                FirstOrDefault(x => x.Id == userId);
            return user;
        }
        public User FindUserByUserNameAndPassword(string userName, string password)
        {
            var user = _context.Users.
                FirstOrDefault(x => x.UserName == userName && x.Password == password);
            return user;
        }
        public List<User> FindUserByUserName(string userName)
        {
            return _context.Users.Where(x => x.UserName == userName).ToList();
        }
    }
}
