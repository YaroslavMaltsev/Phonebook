namespace Phonebook.ApplicationServices.ApplicationDTOs
{
    public sealed class ContactDTO
    {
        public required string LastName { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string PhoneNumber { get; set; }
        public required AdressContatDTO AdressContatDTO { get; set; }
    }
}
