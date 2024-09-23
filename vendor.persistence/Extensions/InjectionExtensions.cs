using Microsoft.Extensions.DependencyInjection;
using vendor.application.Repositories;
using vendor.persistence.Repositories;

namespace vendor.persistence.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services) 
        {
            services.AddTransient<IVendorRepository, VendorRepository>();

            return services;
        }
    }
}
