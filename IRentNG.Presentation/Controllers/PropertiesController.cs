using IRentNG.Entities.Enums;
using IRentNG.Presentation.ActionFilters;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
using IRentNG.Shared.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IRentNG.Presentation.Controllers
{
    [Route("api/users/{userId}/properties")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PropertiesController(IServiceManager service) => _service = service;


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetPropertiesForUser(Guid userId, [FromQuery] PropertyParameters propertyParameters)
        {
            var pagedResult = await _service.PropertyService.GetPropertiesAsync(userId, propertyParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));

            return Ok(pagedResult.properties);
        }


        [HttpGet("/api/properties")]
        //[Authorize]
        public async Task<IActionResult> GetAllPropertiesListing([FromQuery] PropertyParameters propertyParameters)
        {
            var pagedResult = await _service.PropertyService.GetAllPropertiesInDatabaseAsync(propertyParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));

            return Ok(pagedResult.properties);
        }

        [HttpGet("/api/properties/{id:guid}/contact")]
        [Authorize]
        public async Task<IActionResult> GetPropertyContactInfo(Guid id)
        {
            var propertyContact = await _service.PropertyService.GetLandlordContactForPropertyAsync(id, trackChanges: false);
            return Ok(propertyContact);
        }

        [HttpGet("{id:guid}", Name = "GetPropertyForUser")]
        [Authorize]
        public async Task<IActionResult> GetPropertyForUser(Guid userId, Guid id)
        {
            var property = await _service.PropertyService.GetPropertyAsync(userId, id, trackChanges: false);
            return Ok(property);
        }


        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "LandLord")]
        public async Task<IActionResult> CreatePropertyForUser(Guid userId, [FromForm] PropertyForCreationDto property)
        {
            var createdProperty = await _service.PropertyService.CreatePropertyForUserAsync(userId, property, trackChanges: false);

            return CreatedAtRoute("GetPropertyForUser", new { userId, id = createdProperty.Id }, createdProperty);
        }


        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Landlord")]
        public async Task<IActionResult> DeletePropertyForUser(Guid userId, Guid id)
        {
            await _service.PropertyService.DeletePropertyForUserAsync(userId, id, trackChanges: false);
            return NoContent();
        }


        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Landlord")]
        public async Task<IActionResult> UpdatePropertyForUser(Guid userId, Guid id, [FromForm] PropertyForUpdateDto property)
        {
            await _service.PropertyService.UpdatePropertyForUserAsync(userId, id, property, userTrackChanges: false, propTrackChanges: true);

            return NoContent();
        }


        [HttpPost("{id:guid}/coverphoto")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "LandLord")]
        public async Task<IActionResult> UploadCoverPhoto(Guid userId, Guid id, IFormFile photo)
        {
            var propertyForPhotoUpload = await _service.PropertyService.UploadCoverPhotoAsync(userId, id, photo, trackChanges: true);

            return Ok(propertyForPhotoUpload.CoverPhotoURL);
        }

        [HttpPost("{id:guid}/property-photos")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        //[Authorize(Roles = "LandLord")]
        public async Task<IActionResult> UploadPropertyPhotos(Guid userId, Guid id, List<IFormFile> photos)
        {
            var propertyForPhotosUploads = await _service.PropertyService.UploadPropertyPhotosAsync(userId, id, photos, trackChanges: true);

            return Ok(propertyForPhotosUploads.PropertyPhotosURLs);
        }

        [HttpPost("{id:guid}/amenities")]
        //[Authorize(Roles = "LandLord")]
        public async Task<IActionResult> AddPropertyAmenities(Guid userId, Guid id, [FromForm]List<PropertyAmenitiesDto> amenities)
        {
            
            var propertyForAmenitiesUpdate = await _service.PropertyService.AddPropertyAmenitiesAsync(userId, id, amenities, trackChanges: false);

            return Ok(propertyForAmenitiesUpdate.PropertyAmenities);
        }
    }
}
