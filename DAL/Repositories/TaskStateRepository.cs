using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class TaskStateRepository : IRepository<TaskState>, ITaskStateRepository
    {
        private TaskManagerContext _context;
        public TaskStateRepository(TaskManagerContext taskManager)
        {
            _context = taskManager;
        }
        public void Create(TaskState item)
        {
            _context.TaskStates.Add(item);
        }

        public TaskState Get(int id)
        {
            return _context.TaskStates.Find(id);
        }

        public IEnumerable<TaskState> GetAll()
        {
            return _context.TaskStates;
        }
    }
}
