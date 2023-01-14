using AutoMapper;
using TutApp.Core.DTO_s;
using TutApp.Data.Models;

namespace TutApp.Core.Configurations
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        { 
            CreateMap<Article, ArticleGetDTO>().ReverseMap();
        }
    }
}
