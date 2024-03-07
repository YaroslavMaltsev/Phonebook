using System.ComponentModel.DataAnnotations;

namespace Phonebook.Domain.Models
{
    public sealed class AdressContact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string City { get; set; }
        [Required]
        public required string Street { get; set; }
        [Required]
        public required string HouseNumber { get; set; }
    }
}
