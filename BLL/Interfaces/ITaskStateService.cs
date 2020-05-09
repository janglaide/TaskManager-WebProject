using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ITaskStateService
    {
        IEnumerable<TaskStateDTO> GetAll();
        TaskStateDTO Get(int id);
    }
}
