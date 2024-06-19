using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Service.DTOs.ToDoLists
{
    public class ToDoListForResultDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string TaskDescription { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public long UserId { get; set; }
    }
}
