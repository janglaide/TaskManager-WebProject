using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class UserTaskDTO
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public TaskDTO Task { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
    }
}
