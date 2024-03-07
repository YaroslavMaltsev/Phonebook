using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Phonebook.ApplicationServices.Configuration;
using Phonebook.DAL.Configuration;
using Phonebook.View.ExeptionHandlers;
using Phonebook.View.Views;

namespace Phonebook.View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
                ApplicationConfiguration.Initialize();

                IConfiguration configuration = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", optional: false)
                 .Build();

                var services = new ServiceCollection();

                services.AddSingleton<MainWindow>();
                services.AddSingleton(configuration);
                services.DAlConfigurationDescriotion(configuration);
                services.ApplicationConfigurationDescriotion();
                services.AddSingleton<GetContactByPhoneNumberWindow>();
                services.AddSingleton<PasteContactDetailsWindow>();
                using ServiceProvider servicesProvider = services.BuildServiceProvider();
                var mainWindow = servicesProvider.GetRequiredService<MainWindow>();
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler.HandleException);
                try
                {
                    Application.Run(mainWindow);
                }
                catch
                {
                
                }
      
        }
    }
}