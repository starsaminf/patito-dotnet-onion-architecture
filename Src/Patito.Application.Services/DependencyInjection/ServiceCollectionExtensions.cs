using Microsoft.Extensions.DependencyInjection;
using Patito.Application.Services.Abstractions;

namespace Patito.Application.Services.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddSingleton<IExampleHelloWorldService, ExampleHelloWorldService>();
            return services;
        }
    }
}