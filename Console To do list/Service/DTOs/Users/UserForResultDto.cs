using Console_To_do_list.Domain.Models;
using Console_To_do_list.Service.DTOs.ToDoLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Service.DTOs.Users
{
    public class UserForResultDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<ToDoListForResultDto> ToDoLists { get; set; }
    }
}
