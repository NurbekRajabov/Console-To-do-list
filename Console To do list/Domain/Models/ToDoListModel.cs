using Console_To_do_list.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Domain.Models
{
    public class ToDoListModel : AuditableModel
    {
        public string Title { get; set; }
        public string TaskDescription { get; set; }
        public bool Status { get; set; }

        public long UserId { get; set; }
        public UserModel User { get; set; }
    }
}
