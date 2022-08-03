using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patito.Infraestructure.Database.DependencyInjection
{
    public class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }        
    }
}