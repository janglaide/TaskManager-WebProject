using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class UserRepository : IRepository<User>, IUserRepository
    {
        private TaskManagerContext _context;
        public UserRepository(TaskManagerContext taskManager)
        {
            _context = taskManager;
        }
        public void Create(User item)
        {
            _context.Users.Add(item);
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}
