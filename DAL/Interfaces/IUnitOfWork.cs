using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITaskRepository TaskRepository { get; }
        ITaskStateRepository TaskStateRepository { get; }
        IUserRepository UserRepository { get; }
        IUserTaskRepository UserTaskRepository { get;}
        void Save();
    }
}
