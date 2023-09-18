using IRentNG.Presentation.ActionFilters;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Claims;

namespace IRentNG.Presentation.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthenticationController(IServiceManager service) => _service = service;


        [HttpPost("signup")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterTenantUser([FromForm] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration, "Tenant");
            if (!result.identity.Succeeded)
            {
                foreach (var error in result.identity.Errors)
                    ModelState.TryAddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }
            string encodedToken = System.Text.Encodings.Web.UrlEncoder.Default.Encode(result.token);
            string callback_url = Request.Scheme + "://" + Request.Host + $"/api/authentication/confirm-email/{userForRegistration.Email}/{encodedToken}";

            _service.AuthenticationService.SendConfirmationEmail(userForRegistration.Email, callback_url);
            return StatusCode(201, "Account created successfully. Please confirm your email");

        }


        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromForm] UserForAuthenticationDto user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user))
                return Unauthorized();

            return Ok(new { Token = await _service.AuthenticationService.CreateToken() });
        }


        [HttpGet("confirm-email/{email}/{token}")]
        public async Task<IActionResult> ConfirmEmail(string email, string token)
        {
            string decodedToken = WebUtility.UrlDecode(token);
            await _service.AuthenticationService.ConfirmEmailAddress(email, decodedToken);

            return Ok("Your email has been confirmed");
        }


        [HttpGet("reset-password/{token}")]
        public async Task<IActionResult> ResetPassword(string token, [FromForm] UserForAuthenticationDto requestDto)
        {
            string decodedToken = WebUtility.UrlDecode(token);

            await _service.AuthenticationService.ResetPassword(decodedToken, requestDto);
            return Ok("Your password has been reset successfully");
        }


        [HttpGet("forget-password/{email}")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            string resetToken = await _service.AuthenticationService.GeneratePasswordResetToken(email);

            string encodedToken = System.Text.Encodings.Web.UrlEncoder.Default.Encode(resetToken);

            //Change to call the frontend url for entering new password and resetting with this resetToken passed in the header
            string callback_url = Request.Scheme + "://" + Request.Host + $"/api/authentication/confirm-email/{email}/{encodedToken}";//currently backend url

            _service.AuthenticationService.SendResetPasswordEmail(email, callback_url);
            return StatusCode(200, "Password reset successfully sent to your email.");

        }


        [HttpGet("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequestDto requestDto)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userNameClaim = claimsIdentity.FindFirst(ClaimTypes.Name);
            string email = userNameClaim.Value;
            await _service.AuthenticationService.ChangePassword(email, requestDto);
            return Ok("Your password has been changed successfully");
        }
    }
}
