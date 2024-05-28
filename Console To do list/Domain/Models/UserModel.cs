using Console_To_do_list.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Domain.Models
{
    public class UserModel : AuditableModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<ToDoListModel> ToDoLists { get; set; }
    }
}
