using IRentNG.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IRentNG.Presentation.Controllers
{
    [Route("api/users/{userId}/properties")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PropertiesController(IServiceManager service) => _service = service;


        [HttpGet]
        public async Task<IActionResult> GetPropertiesForUser(Guid userId)
        {
            var properties = await _service.PropertyService.GetPropertiesAsync(userId, trackChanges: false);
            return Ok(properties);
        }


        [HttpGet("{id:guid}", Name = "GetPropertyForUser")]
        public async Task<IActionResult> GetPropertyForUser(Guid userId, Guid id)
        {
            var property = await _service.PropertyService.GetPropertyAsync(userId, id, trackChanges: false);
            return Ok(property);
        }
    }
}
