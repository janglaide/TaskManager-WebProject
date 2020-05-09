using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class UserTaskRepository : IRepository<UserTask>, IUserTaskRepository
    {
        private TaskManagerContext _context;
        public UserTaskRepository(TaskManagerContext taskManager)
        {
            _context = taskManager;
        }
        public void Create(UserTask item)
        {
            _context.UserTasks.Add(item);
        }

        public UserTask Get(int id)
        {
            return _context.UserTasks.Find(id);
        }

        public IEnumerable<UserTask> GetAll()
        {
            return _context.UserTasks;
        }
    }
}
