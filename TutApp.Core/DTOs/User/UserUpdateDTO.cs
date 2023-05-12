using System.ComponentModel.DataAnnotations;

namespace TutApp.Core.DTOs
{
    public class UserUpdateDTO : UserMainDTO
    {
        [Required]
        [EmailAddress]
        public string newEmail { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        public string? HobbiesList { get; set; }
        public string? FavCategoriesList { get; set; }
        public string? AboutMe { get; set; }
    }
}
