using AutoMapper;
using Console_To_do_list.Service.DTOs.ToDoLists;
using Console_To_do_list.Service.Exceptions;
using Console_To_do_list.Service.Interfaces;
using Console_To_do_list.Service.Mappings;
using Data.Entities;
using Data.IRepositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Console_To_do_list.Service.Services
{
    public class ToDoListService : IToDoList
    {
        private readonly IMapper mapper = MappingProfile.Initialize();
        private readonly IRepository<User> _userRepository = new UserRepository();
        private readonly IRepository<ToDoList> _toDoListRepository = new ToDoRepository();
        public async Task<ToDoListForResultDto> CreateAsync(ToDoListForCreationDto dto)
        {
            var task = mapper.Map<ToDoList>(dto);
            task.CreatedAt = DateTime.UtcNow;

            var result = await _toDoListRepository.CreateAsync(task);
            return mapper.Map<ToDoListForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var task = await _toDoListRepository.SelectByIdAsync(id);
            if (task is null)
                return false;
            // throw new CustomException(404, "Task is not found");

            return await _toDoListRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ToDoListForResultDto>> RetrieveAllAsync()
        {
            var taskList = await _toDoListRepository.SelectAll().ToListAsync();
            var result = mapper.Map<IEnumerable<ToDoListForResultDto>>(taskList);
            return result;
        }

        public async Task<ToDoListForResultDto> RetrieveByIdAsync(long id)
        {
            var task = await _toDoListRepository.SelectByIdAsync(id);
            if (task is null)
                return null;
            //throw new CustomException(404, "Task is not found");
            return mapper.Map<ToDoListForResultDto>(task);
        }

        public async Task<ToDoListForResultDto> UpdateAsync(ToDoListForUpdateDto dto)
        {
            var task = await _toDoListRepository.SelectByIdAsync(dto.Id);
            if (task is null)
                return null;
            //throw new CustomException(404, "Task is not found");

            var list = mapper.Map<ToDoList>(dto);
            list.UpdatedAt = DateTime.UtcNow;
            list.CreatedAt = task.CreatedAt;
            var result = await _toDoListRepository.UpdateAsync(list);
            return mapper.Map<ToDoListForResultDto>(result);
        }
    }
}
