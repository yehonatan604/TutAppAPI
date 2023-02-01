using Microsoft.AspNetCore.Identity;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Core.Contracts
{
    public interface IAuthRepository
    {
        Task<IEnumerable<IdentityError>> Register(UserRegisterDTO user);
        Task<UserReturnDto?> Login(UserLoginDTO user);
        Task<bool> UpdateUser(UserUpdateDTO user);
        Task<string> CreateRefreshToken();
        Task<UserReturnDto?> VerifyRefreshToken(UserReturnDto request);
    }
}
