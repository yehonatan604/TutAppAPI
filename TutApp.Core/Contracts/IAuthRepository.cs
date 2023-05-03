using Microsoft.AspNetCore.Identity;
using TutApp.Core.DTOs;

namespace TutApp.Core.Contracts
{
    public interface IAuthRepository
    {
        Task<IEnumerable<IdentityError>> Register(UserRegisterDTO user);
        Task<UserTokenDTO?> Login(UserLoginDTO user);
        Task<string> CreateRefreshToken();
        Task<bool> UpdateUser(UserUpdateDTO user);
        Task<UserTokenDTO?> VerifyRefreshToken(UserTokenDTO request);
        Task<UserReturnDto?> GetUser(string UserId);
    }
}
