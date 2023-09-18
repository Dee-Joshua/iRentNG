using System.ComponentModel.DataAnnotations;

namespace IRentNG.Shared.DataTransferObjects
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }
    }
}
