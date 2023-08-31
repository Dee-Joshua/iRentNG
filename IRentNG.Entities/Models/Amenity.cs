using System.ComponentModel.DataAnnotations.Schema;

namespace IRentNG.Entities.Models
{
    public class Amenity
    {
        [Column("AmenityId")]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Property> Properties { get; set; } = new();
    }
}
