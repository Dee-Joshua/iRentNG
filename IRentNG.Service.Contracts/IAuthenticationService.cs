using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace IRentNG.Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration, string role);

        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
