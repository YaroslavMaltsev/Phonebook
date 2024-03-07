using Phonebook.ApplicationServices.ApplicationDTOs;
using Phonebook.ApplicationServices.Interfaces;
using Phonebook.Domain.Interfaces;

namespace Phonebook.ApplicationServices.Services
{
    public sealed class GetContactByPhoneNumberService : IGetContactByPhoneNumberService
    {
        private readonly IRepository _repository;

        public GetContactByPhoneNumberService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<ContactDTO> GetContactBPhoneNumber(string phoneNumber)
        {
            try 
            {
                var contact = await _repository.GetСontactByPhoneNumberAsync(phoneNumber);

                ArgumentNullException.ThrowIfNull(contact);

                var contactDTO = new ContactDTO
                {
                    Name = contact.Name,
                    Surname = contact.Surname,
                    LastName = contact.LastName,
                    DateOfBirth = contact.DateOfBirth,
                    PhoneNumber = contact.PhoneNumber,
                    AdressContatDTO = new AdressContatDTO
                    {
                        City = contact.AdressContact.City,
                        Street = contact.AdressContact.Street,
                        HouseNumber = contact.AdressContact.HouseNumber
                    }

                };

                return contactDTO;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
