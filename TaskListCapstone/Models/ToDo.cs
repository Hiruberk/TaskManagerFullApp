using System;
using System.Collections.Generic;

#nullable disable

namespace TaskListCapstone.Models
{
    public partial class ToDo
    {
        public int ToDoId { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }
        public DateTime DueDate { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
