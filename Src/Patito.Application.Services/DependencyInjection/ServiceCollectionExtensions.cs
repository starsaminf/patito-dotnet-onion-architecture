using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patito.Application.Services.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}