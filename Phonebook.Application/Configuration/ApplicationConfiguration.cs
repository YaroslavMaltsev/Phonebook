using Microsoft.Extensions.DependencyInjection;
using Phonebook.ApplicationServices.Interfaces;
using Phonebook.ApplicationServices.Services;

namespace Phonebook.ApplicationServices.Configuration
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection ApplicationConfigurationDescriotion(this IServiceCollection services)
        {

            services.AddSingleton<IGetContactByPhoneNumberService, GetContactByPhoneNumberService>();
            services.AddSingleton<IAddContactService, AddContactService>();

            return services;
        }
    }
}
