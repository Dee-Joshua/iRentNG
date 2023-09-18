using IRentNG.Entities.Enums;

namespace IRentNG.Shared.DataTransferObjects
{
    public record PropertyDto(Guid Id, string Title, string Description, string Address, string Structure, string Privacy, int Bedrooms, int Bathrooms, string PropertyAmenities, decimal price, string Duration, string CoverPhotoURL, string PropertyPhotosURLs);
}
