using System.ComponentModel.DataAnnotations;

namespace TutApp.Core.DTOs
{
    public class UserRegisterDTO : UserLoginDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime Dob { get; set; }
    }
}
