using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TaskStateId { get; set; }
        public TaskState TaskState { get; set; }

        public DateTime CreationDatetime { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime Deadline { get; set; }

        public int ManagerId { get; set; }
        public User Manager { get; set; }

        public ICollection<UserTask> UserTasks { get; set; }
    }
}
