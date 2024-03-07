using Phonebook.ApplicationServices.ApplicationDTOs;
using Phonebook.ApplicationServices.Interfaces;
using Phonebook.DAL.Implementation;
using Phonebook.Domain.Interfaces;
using Phonebook.Domain.Models;

namespace Phonebook.ApplicationServices.Services
{
    public sealed class AddContactService : IAddContactService
    {
        private readonly IRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public AddContactService(IRepository repository,
            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddContactAsync(ContactDTO contactDTO)
        {
            try
            {
                var contact = new Сontact
                {
                    Name = contactDTO.Name,
                    Surname = contactDTO.Surname,
                    LastName = contactDTO.LastName,
                    DateOfBirth = contactDTO.DateOfBirth,
                    PhoneNumber = contactDTO.PhoneNumber,
                    AdressContact = new AdressContact
                    {
                        City = contactDTO.AdressContatDTO.City,
                        Street = contactDTO.AdressContatDTO.Street,
                        HouseNumber = contactDTO.AdressContatDTO.HouseNumber
                    }
                };

                await _repository.CreateAsync(contact);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
