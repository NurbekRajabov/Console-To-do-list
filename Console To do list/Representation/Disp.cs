using Console_To_do_list.Service.DTOs.ToDoLists;
using Console_To_do_list.Service.DTOs.Users;
using Console_To_do_list.Service.Interfaces;
using Console_To_do_list.Service.Services;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Representation
{
    public class Disp
    {
        private readonly IUserService _userService = new UserService();
        private readonly IToDoList _toDoListService = new ToDoListService();

        public void Display()
        {
            Console.WriteLine("Welcome to our 'ToDo' app");
        revisit:
            Console.WriteLine("Please, Enter the number you want");
            Console.WriteLine("Press 1: Create user");
            Console.WriteLine("Press 2: Enter your profile");
            Console.WriteLine("Press 3: View Users");
            Console.WriteLine("Press 4: Exit");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    CreateUser();
                    goto revisit;
                case 2:
                    PersonalProfile();

                    break;
                case 3:
                    DisplayAll();
                    goto revisit;
                case 4:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
        public void CreateTask()
        {

        }
        public void CreateUser()
        {
            Console.Write("FirstName:");
            string firstName = Console.ReadLine();
            Console.Write("LastName:");
            string lastName = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();

            UserForCreationDto user = new UserForCreationDto()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            var u = _userService.CreateAsync(user).Result;
            Console.WriteLine("User is created");
            Console.WriteLine();
        }
        public void DisplayAll()
        {
            var users = _userService.RetrieveAllAsync().Result;
            foreach (var user in users)
            {
                Console.WriteLine($"Id:{user.Id}  FirstName:{user.FirstName}  LastName:{user.LastName}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void PersonalProfile()
        {
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            var user = new UserForAccessProfileDTO()
            {
                Email = email,
                Password = password
            };
            var checkedUser = _userService.AccessProfile(user).Result;
            ProfilePanel(checkedUser);

        }
        public async void ProfilePanel(UserForResultDto dto)
        {
            Console.Clear();
            if (dto.ToDoLists is null)
                dto.ToDoLists = new List<ToDoListForResultDto>();
            re:
            ToDoListForCreationDto task = new ToDoListForCreationDto();
            Console.WriteLine($"{dto.FirstName} please choose one of them:");
            Console.WriteLine("Press 1: Add Task");
            Console.WriteLine("Press 2: Delete Task");
            Console.WriteLine("Press 3: View Task lists");
            Console.WriteLine("Press 4: Modify Task");
            Console.WriteLine("Press 5: Edit Profile");
            Console.WriteLine("Press 6: Exit");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Task title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Task:");
                    string description = Console.ReadLine();
                    task.Title = title;
                    task.TaskDescription = description;
                    task.Status = false;
                    task.UserId = dto.Id;
                    var result = _toDoListService.CreateAsync(task).Result;
                    dto.ToDoLists.Add(result);
                    Console.WriteLine("Task added");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Task Id:");
                    int id = int.Parse(Console.ReadLine());
                    await _toDoListService.RemoveAsync(id);
                    Console.WriteLine("Deleted successfully");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;

                case 3:
                    foreach (var item in (_toDoListService.RetrieveAllAsync().Result.Where(t => t.UserId == dto.Id)))
                    {
                        Console.WriteLine($"Id:{item.Id}\nUserId:{item.UserId}\nTitle:{item.Title}\n{item.TaskDescription}");
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    ToDoListForUpdateDto updatedDto = new ToDoListForUpdateDto();
                    Console.WriteLine("Enter the task id you want to modify:");
                    long taskId = long.Parse(Console.ReadLine());
                    var t = _toDoListService.RetrieveByIdAsync(taskId).Result;
                    Console.WriteLine("Task title:");
                    string titleUpdated = Console.ReadLine();
                    Console.WriteLine("Task:");
                    string descriptionUpdated = Console.ReadLine();
                    updatedDto.Id = taskId;
                    updatedDto.Title = titleUpdated;
                    updatedDto.TaskDescription = descriptionUpdated;
                    updatedDto.Status = false;
                    updatedDto.UserId = dto.Id;
                    var updatedResult = await _toDoListService.UpdateAsync(updatedDto);
                    dto.ToDoLists.Add(updatedResult);
                    Console.WriteLine("Task updated");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            goto re;
        }
    }
}
