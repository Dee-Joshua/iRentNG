using IRentNG.Entities.Enums;

namespace IRentNG.Shared.DataTransferObjects
{
    public record PropertyDto(Guid Id, string Title, string Description, string Address, PropertyType Structure, PrivacyType Privacy, int Bedrooms, int Bathrooms, decimal price, RentInterval Duration, string CoverPhotoURL);
}
