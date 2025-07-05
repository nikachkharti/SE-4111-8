using Microsoft.Extensions.DependencyInjection;
using TinyBank.Repository.Contracts;
using TinyBank.Repository.Implementations;
using TinyBank.Service.Implementations;
using TinyBank.Service.Interfaces;
using TinyBank.Service.Mapping;

namespace TinyBank.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(provider.GetRequiredService<Main>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            #region MAPSTER
            MapsterConfig.RegisterMappings();
            #endregion

            #region REPOSITORY
            services.AddScoped<ICustomerRepository>(sp => new CustomerRepository(""));
            #endregion

            #region SERVICE
            services.AddScoped<ICustomerService, CustomerService>();
            #endregion

            services.AddSingleton<Main>();
        }


    }
}