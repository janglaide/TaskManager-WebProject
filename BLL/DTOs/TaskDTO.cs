using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TaskStateId { get; set; }
        public TaskStateDTO TaskState { get; set; }

        public DateTime CreationDatetime { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime Deadline { get; set; }

        public int ManagerId { get; set; }
        public UserDTO Manager { get; set; }

        public ICollection<UserTaskDTO> UserTasks { get; set; }
    }
}
