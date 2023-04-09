using Microsoft.AspNetCore.Identity;

namespace TutApp.Data.Models
{
    public class User : IdentityUser
    {
        public DateTime DOB { get; set; }
        public string Password { get; set; }
        public UserTypes UserType { get; set; }
        public UserStatusTypes UserStatus { get; set; }

        public string? HobbiesList { get; set; }
        public string? FavCategoriesList { get; set; }
        public string? AboutMe { get; set; }
    }
}
