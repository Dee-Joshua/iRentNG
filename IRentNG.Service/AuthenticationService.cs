using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Entities.Exceptions;
using IRentNG.Entities.Models;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IRentNG.Service
{
    internal sealed class AuthenticationService : IAuthenticationService
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private User _user;
        private readonly IEmailService _emailService;

        public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration, IEmailService emailService)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
        }

        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken
                (
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
                signingCredentials: signingCredentials
                );
            return tokenOptions;
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        public async Task<(IdentityResult identity, string token)> RegisterUser(UserForRegistrationDto userForRegistration, string role)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            string token = string.Empty;
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, role);
                token = await  _userManager.GenerateEmailConfirmationTokenAsync(user);
            }
            return (result, token);
            
        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
        {
            _user = await _userManager.FindByEmailAsync(userForAuth.Email);

            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password));

            if (!result)
                _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong email or password.");
            if (!(await _userManager.IsEmailConfirmedAsync(_user)))
                throw new UnauthorizedAccessException("Email not confirmed, please check your inbox and confirm your email.");
            return result;
        }

        public void SendConfirmationEmail(string email, string callback_url)
        {
            string title = "Welcome to iRentNG";
            string body = $"\r\nHi,\r\nThanks for signing up!\r\nPlease confirm your email address using the link below. \r\n{callback_url} \r\n\r\nIf you didn’t request this email, there’s nothing to worry about, you can safely ignore it.\r\n\r\nCheers,\r\niRentNg Team";
            _emailService.SendEmail(email, title, body);
        }

        public async Task ConfirmEmailAddress(string email, string token)
        {
            string trimedToken = token.Replace(" ", "+");
            User user = await _userManager.FindByEmailAsync(email)
              ?? throw new UserNotFoundException(email);
            if (user.EmailConfirmed)
            {
                throw new UnauthorizedAccessException($"Email: {user.Email} has already been confirmed");
            }
            IdentityResult result = await _userManager.ConfirmEmailAsync(user, trimedToken);
            if (!result.Succeeded)
            {
                throw new UnauthorizedAccessException($"Failed, unable to confirm your email: {user.Email}");
            }
        }

        public void SendResetPasswordEmail(string email, string callback_url)
        {
            string title = "iRentNg Reset Password";
            string body = $"We hope this message finds you well. We wanted to inform you that a request to reset the password for your DropMate account was received. If you did not initiate this password reset, please disregard this email. Your account security is important to us, and we take all necessary precautions to protect it.<p/>Please click on the link to reset your password. <p/> <a href={callback_url}>Reset Your Password";
            _emailService.SendEmail(email, title, body);
        }

        public async Task ResetPassword(string token, UserForAuthenticationDto requestDto)
        {
            string trimedToken = token.Replace(" ", "+");
            User user = await _userManager.FindByEmailAsync(requestDto.Email)
                ?? throw new UserNotFoundException(requestDto.Email);
            IdentityResult result = await _userManager.ResetPasswordAsync(user, trimedToken, requestDto.Password);
            if (!result.Succeeded)
            {
                string errors = string.Empty;
                foreach (var error in result.Errors)
                {
                    errors += error.Description.TrimEnd('.') + ", ";
                }
                throw new PasswordResetFailedException(errors.TrimEnd(',', ' '));
            }
        }

        public async Task<string> GeneratePasswordResetToken(string email)
        {
            User user = await _userManager.FindByEmailAsync(email)
                ?? throw new UserNotFoundException(email);
            return await _userManager.GeneratePasswordResetTokenAsync(user);
        }

        public async Task ChangePassword(string email, ChangePasswordRequestDto requestDto)
        {
            User user = await _userManager.FindByEmailAsync(email)
                ?? throw new UserNotFoundException(email);
            IdentityResult result = await _userManager.ChangePasswordAsync(user, requestDto.OldPassword, requestDto.NewPassword);
            if (!result.Succeeded)
            {
                string errors = string.Empty;
                foreach (var error in result.Errors)
                {
                    errors += error.Description.TrimEnd('.') + ", ";
                }

                throw new PasswordResetFailedException(errors.TrimEnd(',', ' '));
            }
        }
    }
}
