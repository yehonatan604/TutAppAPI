using TutApp.Data.Models;

namespace TutApp.Core.DTOs
{
    public abstract class UserMainDTO
    {
        public string Email { get; set; }
    }

    public class UserLoginDTO : UserMainDTO
    {
        public string Password { get; set; }
    }

    public class UserRegisterDTO : UserLoginDTO
    {
        public string UserName { get; set; }
        public DateTime Dob { get; set; }
    }

    public class UserUpdateDTO : UserMainDTO
    {
        public string newEmail { get; set; }
        public string UserName { get; set; }
        public DateTime Dob { get; set; }
        public string? HobbiesList { get; set; }
        public string? FavCategoriesList { get; set; }
        public string? AboutMe { get; set; }
    }

    public class UserReturnDto : UserRegisterDTO
    {
        public UserTypes UserType { get; set; }
        public UserStatusTypes UserStatusType { get; set; }
        public string? HobbiesList { get; set; }
        public string? FavCategoriesList { get; set; }
        public string? AboutMe { get; set; }
        
    }

    public class UserTokenDTO
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }

}
