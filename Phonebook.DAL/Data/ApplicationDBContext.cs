using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Phonebook.Domain.Models;

namespace Phonebook.DAL.Data
{
    public sealed class ApplicationDBContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    object value = optionsBuilder.UseMySQL("server=localhost;port=3306;database=PhoneBook;user=root;password=11022003;");
        //}
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Сontact> Сontacts { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Сontact>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Сontacts_Id");
            });
        }
        public DbSet<AdressContact> AdresContacts { get; set; }
    }
}
