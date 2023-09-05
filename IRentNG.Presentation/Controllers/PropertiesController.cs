using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
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


        [HttpPost]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePropertyForUser(Guid userId, [FromBody] PropertyForCreationDto property)
        {
            var createdProperty = await _service.PropertyService.CreatePropertyForUserAsync(userId, property, trackChanges: false);

            return CreatedAtRoute("GetPropertyForUser", new {userId, id = createdProperty.Id}, createdProperty);
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeletePropertyForUser(Guid userId, Guid id)
        {
            await _service.PropertyService.DeletePropertyForUserAsync(userId, id, trackChanges: false);
            return NoContent();
        }


        [HttpPut("{id:guid}")]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdatePropertyForUser(Guid userId, Guid id, [FromBody] PropertyForUpdateDto property)
        {
            await _service.PropertyService.UpdatePropertyForUserAsync(userId, id, property, userTrackChanges: false, propTrackChanges: true);

            return NoContent();
        }
    }
}
