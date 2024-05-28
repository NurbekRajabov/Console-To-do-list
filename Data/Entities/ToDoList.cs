using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ToDoList : Auditable
    {
        public string Title { get; set; }
        public string TaskDescription { get; set; }
        public bool Status { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}
