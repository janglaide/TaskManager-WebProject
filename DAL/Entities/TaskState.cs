using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class TaskState
    {
        public int Id { get; set; }
        public string State { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
