using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<TaskDTO> GetAll();
        TaskDTO Get(int id);
    }
}
