using System.ComponentModel.DataAnnotations.Schema;

namespace IRentNG.Entities.Models
{
    public class PropertyPhoto
    {
        [Column("PhotoId")]
        public int Id { get; set; }
        public string PhotoPath { get; set; }

        [ForeignKey(nameof(Property))]
        public Guid PropertyID { get; set; } // Foreign Key
        public Property Property { get; set; } // Navigation property
    }
}
