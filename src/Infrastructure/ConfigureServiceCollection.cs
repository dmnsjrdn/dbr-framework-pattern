using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServiceCollection
{
    // TODO: add include IConfiguration
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        return services;
    }
}