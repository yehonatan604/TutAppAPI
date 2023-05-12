namespace TutApp.Core.DTOs
{
    public class UserTokenDTO
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
