using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public ICollection<UserTaskDTO> UserTasks { get; set; }
        public ICollection<TaskDTO> GivenTasks { get; set; }
    }
}
