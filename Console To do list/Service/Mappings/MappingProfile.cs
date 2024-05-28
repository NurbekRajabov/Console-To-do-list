using AutoMapper;
using Console_To_do_list.Service.DTOs.ToDoLists;
using Console_To_do_list.Service.DTOs.Users;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_To_do_list.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public static IMapper Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserForCreationDto>().ReverseMap();
                cfg.CreateMap<User, UserForUpdateDto>().ReverseMap();
                cfg.CreateMap<User, UserForResultDto>().ReverseMap();
                cfg.CreateMap<User, UserForAccessProfileDTO>().ReverseMap();
                cfg.CreateMap<ToDoList, ToDoListForCreationDto>().ReverseMap();
                cfg.CreateMap<ToDoList, ToDoListForUpdateDto>().ReverseMap();
                cfg.CreateMap<ToDoList, ToDoListForResultDto>().ReverseMap();
            });
            return config.CreateMapper();
        }
    }
}
