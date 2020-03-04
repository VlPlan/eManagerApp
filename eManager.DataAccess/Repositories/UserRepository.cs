using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ManagerDbContext _context;
        public UserRepository(ManagerDbContext context)
        {
            _context = context;
        }


        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(string id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public User GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == username);
        }

        public int Insert(User entity)
        {
            _context.Users.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(User entity)
        {
            _context.Users.Update(entity);
            return _context.SaveChanges();
        }

        public int Delete(string id)
        {
            User user = _context.Users.SingleOrDefault(x => x.Id == id);

            if (user == null)
                return -1;

            _context.Users.Remove(user);
            return _context.SaveChanges();
        }
    }
}
