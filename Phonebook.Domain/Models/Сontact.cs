using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phonebook.Domain.Models
{
    public sealed class Сontact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Surname { get; set; }
        [Required]
        public required DateTime DateOfBirth { get; set; }
        [Required]
        public required string PhoneNumber { get; set; }
        [ForeignKey(nameof(AdressContact))]
        public int AdressContactId { get; set; }
        public required AdressContact AdressContact { get; set; }
    }
}
