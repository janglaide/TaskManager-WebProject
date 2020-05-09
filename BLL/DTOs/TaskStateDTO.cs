using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class TaskStateDTO
    {
        public int Id { get; set; }
        public string State { get; set; }
        public ICollection<TaskDTO> Tasks { get; set; }
    }
}
