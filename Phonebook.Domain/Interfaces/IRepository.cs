using Phonebook.Domain.Models;

namespace Phonebook.Domain.Interfaces
{
    public interface IRepository
    {
        Task CreateAsync(Сontact сontacts);
        Task<Сontact> GetСontactByPhoneNumberAsync(string phone);
    }
}
