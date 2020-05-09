using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IUserTaskService
    {
        IEnumerable<UserTaskDTO> GetAll();
        UserTaskDTO Get(int id);
    }
}
