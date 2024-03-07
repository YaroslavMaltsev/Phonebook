namespace Phonebook.DAL.DALExeptions
{
    public sealed class SaveChangesExeption : Exception
    {
        public SaveChangesExeption(string? message) : base(message)
        {
        }
    }
}
