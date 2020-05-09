using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class UserTask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
