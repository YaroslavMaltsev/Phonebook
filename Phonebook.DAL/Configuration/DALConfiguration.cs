using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Phonebook.DAL.Data;
using Phonebook.DAL.Implementation;
using Phonebook.Domain.Interfaces;

namespace Phonebook.DAL.Configuration
{
    public static class DALConfiguration
    {
        public static IServiceCollection DAlConfigurationDescriotion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(option =>

             option.UseMySQL("server=localhost;port=3306;database=PhoneBook;user=root;password=11022003;")
             );

            services.AddSingleton<IRepository, Repository>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
