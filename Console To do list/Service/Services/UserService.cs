using AutoMapper;
using Console_To_do_list.Service.DTOs.Users;
using Console_To_do_list.Service.Exceptions;
using Console_To_do_list.Service.Interfaces;
using Console_To_do_list.Service.Mappings;
using Data.Entities;
using Data.IRepositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper = MappingProfile.Initialize();
        private readonly IRepository<User> userRepository = new UserRepository();
        public async Task<UserForResultDto> CreateAsync(UserForCreationDto dto)
        {
            var users = userRepository.SelectAll();
            var user = users.FirstOrDefault(u => u.Password == dto.Password);
            if (user != null)
            {
                return null;
                // throw new CustomException(400, "User is already exist");
            }

            var mappedUser = this.mapper.Map<User>(dto);
            mappedUser.CreatedAt = DateTime.UtcNow;

            var insertedUser = await userRepository.CreateAsync(mappedUser);
            await this.userRepository.SaveChangesAsync();

            return this.mapper.Map<UserForResultDto>(insertedUser);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var user = await userRepository.SelectByIdAsync(id);
            if (user is null)
                return false;
            //throw new CustomException(404, "Course is not found");
            await userRepository.DeleteAsync(id);
            await this.userRepository.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
        {
            var users = await userRepository.SelectAll()
                .Include(t => t.ToDoLists).ToListAsync();
            return mapper.Map<IEnumerable<UserForResultDto>>(users);
        }

        public async Task<UserForResultDto> RetrieveByIdAsync(long id)
        {
            var user = await userRepository.SelectByIdAsync(id);
            if (user == null)
            {
                return null;
                // throw new CustomException(404, "User is not found");
            }
            return mapper.Map<UserForResultDto>(user);
        }

        public async Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto)
        {
            var user = await userRepository.SelectByIdAsync(dto.Id);
            if (user == null)
                return null;
            // throw new CustomException(404, "User is not found");

            User mappedUser = mapper.Map(dto, user);
            mappedUser.UpdatedAt = DateTime.UtcNow;
            await userRepository.SaveChangesAsync();
            return mapper.Map<UserForResultDto>(mappedUser);
        }

        public async Task<UserForResultDto> AccessProfile(UserForAccessProfileDTO dto)
        {
            var users = await userRepository.SelectAll().ToListAsync();
            var user = users.FirstOrDefault(u => u.Password == dto.Password && u.Email == dto.Email);
            if (user == null)
                return null;
            //throw new CustomException(404, "User is not found");

            return mapper.Map<UserForResultDto>(user);
        }
    }
}
