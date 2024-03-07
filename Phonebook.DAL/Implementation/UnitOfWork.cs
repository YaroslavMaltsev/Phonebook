using Phonebook.DAL.DALExeptions;
using Phonebook.DAL.Data;

namespace Phonebook.DAL.Implementation
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _applicationDBContext;

        public UnitOfWork(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }

        public async Task SaveChangesAsync()
        {
            using var transaction = await _applicationDBContext.Database.BeginTransactionAsync();
            try
            {
                var responseSave = await _applicationDBContext.SaveChangesAsync();

                if (responseSave == -1)
                {
                    throw new SaveChangesExeption("Saving error");
                }

                await transaction.CommitAsync();
            }
            catch (SaveChangesExeption)
            {
                await transaction.RollbackAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
