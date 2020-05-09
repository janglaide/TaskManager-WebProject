using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL.Repositories
{
    public class TaskRepository : IRepository<Task>, ITaskRepository
    {
        private TaskManagerContext _context;
        public TaskRepository(TaskManagerContext taskManager)
        {
            _context = taskManager;
        }
        public void Create(Task item)
        {
            _context.Tasks.Add(item);
        }

        public Task Get(int id)
        {
            return _context.Tasks.Find(id);
        }

        public IEnumerable<Task> GetAll()
        {
            return _context.Tasks;
        }
    }
}
