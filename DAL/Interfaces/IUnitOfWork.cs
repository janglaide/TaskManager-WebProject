using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public ITaskRepository TaskRepository { get; }
        public ITaskStateRepository TaskStateRepository { get; }
        public IUserRepository UserRepository { get; }
        public IUserTaskRepository UserTaskRepository { get;}
        public void Save();
    }
}
