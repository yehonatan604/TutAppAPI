using System.ComponentModel.DataAnnotations;

namespace TutApp.Core.DTOs
{
    public abstract class UserMainDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
