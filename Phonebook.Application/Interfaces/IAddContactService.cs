using Phonebook.ApplicationServices.ApplicationDTOs;

namespace Phonebook.ApplicationServices.Interfaces
{
    public interface IAddContactService
    {
        Task AddContactAsync(ContactDTO contactDTO);
    }
}