using AutoMapper;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Configurations
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        { 
            CreateMap<Article, ArticleGetDTO>().ReverseMap();
            CreateMap<Article, ArticleDTO>().ReverseMap();

            CreateMap<User, UserReturnDto>().ReverseMap();
            CreateMap<User, UserRegisterDTO>().ReverseMap();
            CreateMap<UserRegisterDTO, User>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();

            CreateMap<Message, MessageGetDTO>().ReverseMap();
        }
    }
}
