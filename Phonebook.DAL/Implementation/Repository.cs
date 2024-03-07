using Microsoft.EntityFrameworkCore;
using Phonebook.DAL.Data;
using Phonebook.Domain.Interfaces;
using Phonebook.Domain.Models;

namespace Phonebook.DAL.Implementation
{
    public class Repository : IRepository
    {
        private readonly ApplicationDBContext _applicationDBContext;

        public Repository(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
        public async Task CreateAsync(Сontact сontacts)
        {
            await _applicationDBContext.AddAsync(сontacts);
        }

        public async Task<Сontact> GetСontactByPhoneNumberAsync(string phone)
        {
            return await _applicationDBContext.Сontacts.Where(i => i.PhoneNumber == phone)
                .Include
                (i => i.AdressContact)
                .FirstOrDefaultAsync();
        }
    }
}
