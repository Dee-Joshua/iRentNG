using IRentNG.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRentNG.Entities.Models
{
    public class Property
    {
        [Column("PropertyId")]
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public PropertyType Structure { get; set; }
        public PrivacyType Privacy { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public string? PropertyAmenities { get; set; } //Comma separated strings

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public RentInterval Duration { get; set; }
        public string? CoverPhotoURL { get; set; }
        public string? PropertyPhotosURLs { get; set; } //Comma separated strings

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
