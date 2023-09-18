using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace IRentNG.Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<(IdentityResult identity, string token)> RegisterUser(UserForRegistrationDto userForRegistration, string role);
        void SendConfirmationEmail(string email, string callback_url);
        Task ConfirmEmailAddress(string email, string decodedToken);
        void SendResetPasswordEmail(string email, string callback_url);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
        Task ResetPassword(string decodedToken, UserForAuthenticationDto requestDto);
        Task<string> GeneratePasswordResetToken(string email);
        Task ChangePassword(string email, ChangePasswordRequestDto requestDto);
    }
}
