using System.ComponentModel.DataAnnotations;

namespace IRentNG.Shared.DataTransferObjects
{
    public record UserForUpdateDto
    {
        [Required(ErrorMessage = "FullName is required.")]
        public string FullName { get; init; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; init; }

        [Required(ErrorMessage = "PhoneNumber is required.")]
        [RegularExpression(@"^(?:\+234|0)[789][01]\d{8}$", ErrorMessage = "Invalid Nigerian phone number format.")]
        public string PhoneNumber { get; init; }

        [Required(ErrorMessage = "PermanentAddress is required.")]
        public string PermanentAddress { get; init; }
    }
}
