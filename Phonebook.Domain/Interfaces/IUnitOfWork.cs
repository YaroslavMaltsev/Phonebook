
namespace Phonebook.DAL.Implementation
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}