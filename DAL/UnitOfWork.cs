using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private TaskManagerContext _context;
        private ITaskRepository _taskRepository;
        private ITaskStateRepository _taskStateRepository;
        private IUserRepository _userRepository;
        private IUserTaskRepository _userTaskRepository;
        private bool _disposed = false;
        public UnitOfWork(TaskManagerContext context)
        {
            _context = context;
            _taskRepository = new TaskRepository(context);
            _taskStateRepository = new TaskStateRepository(context);
            _userRepository = new UserRepository(context);
            _userTaskRepository = new UserTaskRepository(context);
        }
        public ITaskRepository TaskRepository => _taskRepository ??= new TaskRepository(_context);
        public ITaskStateRepository TaskStateRepository => _taskStateRepository ??= new TaskStateRepository(_context);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
        public IUserTaskRepository UserTaskRepository => _userTaskRepository ??= new UserTaskRepository(_context);

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
