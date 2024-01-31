using CustomerModule.Entities;
using PatternsFramework.Interfaces;

namespace CustomerModule;

public static class ConfigureServiceCollection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPatternsFramework<Customer>, CustomerPatternsFramework>();

        return services;
    }
}