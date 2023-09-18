using Microsoft.AspNetCore.Identity;

namespace IRentNG.Entities.Models
{
    public class User : IdentityUser
    {

        public string FullName { get; set; }
        public string? ProfilePicture { get; set; }
        public string? PermanentAddress { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;

        public ICollection<Property> Properties { get; set; }
    }
}
