using Console_To_do_list.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Service.Interfaces
{
    public interface IUserService
    {
        Task<bool> RemoveAsync(long id);
        Task<UserForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
        Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto);
        Task<UserForResultDto> CreateAsync(UserForCreationDto dto);
        Task<UserForResultDto> AccessProfile(UserForAccessProfileDTO dto);
    }
}
