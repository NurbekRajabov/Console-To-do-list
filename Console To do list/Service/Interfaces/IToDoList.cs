using Console_To_do_list.Service.DTOs.ToDoLists;
using Console_To_do_list.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Service.Interfaces
{
    public interface IToDoList
    {
        Task<bool> RemoveAsync(long id);
        Task<ToDoListForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<ToDoListForResultDto>> RetrieveAllAsync();
        Task<ToDoListForResultDto> UpdateAsync(ToDoListForUpdateDto dto);
        Task<ToDoListForResultDto> CreateAsync(ToDoListForCreationDto dto);
    }
}
