using IRentNG.Presentation.ActionFilters;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IRentNG.Presentation.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _service;
        public UsersController(IServiceManager service) => _service = service;

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _service.UserService.GetAllUsersAsync(trackChanges: false);
            return Ok(users);
        }


        [HttpGet("{id:guid}", Name = "UserById")]
        [Authorize]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _service.UserService.GetUserAsync(id, trackChanges: false);
            return Ok(user);
        }

        [HttpGet("{email}", Name = "UserByEmail")]
        [Authorize]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await _service.UserService.GetUserByEmailAsync(email, trackChanges: false);
            return Ok(user);
        }


        [HttpDelete("{id:guid}")]
        [Authorize]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _service.UserService.DeleteUserAsync(id, trackChanges: false);
            return NoContent();
        }


        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize]
        public async Task<IActionResult> UpdateUser(Guid id, [FromForm] UserForUpdateDto user)
        {
            await _service.UserService.UpdateUserAsync(id, user, trackChanges: true);
            return NoContent();
        }


        [HttpPut("landlord/{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize]
        public async Task<IActionResult> UpdateUserToLandlord(Guid id, [FromForm] UserForUpdateDto user, IFormFile profilePicture)
        {
            await _service.UserService.UpdateUserRoleToLandlordAsync(id, user, profilePicture, "Landlord", trackChanges: true);
            return NoContent();
        }


        [HttpPost("{id:guid}/profilepicture")]
        //[Authorize]
        public async Task<IActionResult> UploadProfilePicture(Guid id, IFormFile photo)
        {
            var uploadedPhoto = await _service.UserService.UploadProfilePictureAsync(id, photo, trackChanges: true);

            return Ok(uploadedPhoto.ProfilePicture);
        }
    }
}
