using Phonebook.ApplicationServices.ApplicationDTOs;

namespace Phonebook.ApplicationServices.Interfaces
{
    public interface IGetContactByPhoneNumberService
    {
        Task<ContactDTO> GetContactBPhoneNumber(string phoneNumber);
    }
}