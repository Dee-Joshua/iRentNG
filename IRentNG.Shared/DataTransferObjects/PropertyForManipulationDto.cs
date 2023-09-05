using IRentNG.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace IRentNG.Shared.DataTransferObjects
{
    public abstract record PropertyForManipulationDto
    {
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; init; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; init; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; init; }

        [Required(ErrorMessage = "Structure is required.")]
        public PropertyType Structure { get; init; }

        [Required(ErrorMessage = "Privacy is required.")]
        public PrivacyType Privacy { get; init; }

        [Required(ErrorMessage = "Bedrooms is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Bedrooms must be at least 1.")]
        public int Bedrooms { get; init; }

        [Required(ErrorMessage = "Bathrooms is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Bathrooms must be at least 1.")]
        public int Bathrooms { get; init; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; init; }

        [Required(ErrorMessage = "Duration is required.")]
        public RentInterval Duration { get; init; }

        [Required(ErrorMessage = "CoverPhotoURL is required.")]
        [Url(ErrorMessage = "Invalid URL format for CoverPhotoURL.")]
        public string CoverPhotoURL { get; init; }
    }
}
