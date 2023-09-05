using IRentNG.Presentation.ActionFilters;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
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
        public async Task<IActionResult> GetUsers()
        {
            var users = await _service.UserService.GetAllUsersAsync(trackChanges: false);
            return Ok(users);
        }


        [HttpGet("{id:guid}", Name = "UserById")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _service.UserService.GetUserAsync(id, trackChanges: false);
            return Ok(user);
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _service.UserService.DeleteUserAsync(id, trackChanges: false);
            return NoContent();
        }


        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UserForUpdateDto user)
        {
            await _service.UserService.UpdateUserAsync(id, user, trackChanges: true);
            return NoContent();
        }
    }
}
