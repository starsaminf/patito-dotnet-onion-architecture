using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Patito.Infraestructure.Database.Abstractions;

namespace Patito.Infraestructure.Database.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IExampleRepository, ExampleRepository>();
            return services;
        }        
    }
}