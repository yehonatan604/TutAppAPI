using TutApp.Data.Models;

namespace TutApp.Core.DTOs
{
    public class UserReturnDto : UserRegisterDTO
    {
        public UserTypes UserType { get; set; }
        public UserStatusTypes UserStatusType { get; set; }
        public string? HobbiesList { get; set; }
        public string? FavCategoriesList { get; set; }
        public string? AboutMe { get; set; }

    }
}
