using AutoMapper;
using Domain.Entities;
using WebUI.Pages;

namespace WebUI.Configuration
{
    public class UiMappingProfile : Profile
    {
        public UiMappingProfile()
        {
            CreateMap<ToDoItem, ToDo>().ReverseMap();
        }
    }
}