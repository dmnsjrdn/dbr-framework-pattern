using OrderModule.Entities;
using PatternsFramework.Interfaces;

namespace OrderModule;

public static class ConfigureServiceCollection
{
    public static IServiceCollection AddOrderModule(this IServiceCollection services)
    {
        services.AddScoped<IPatternsFramework<Order>, OrderPatternsFramework>();
        services.AddScoped<IPatternsFramework<OrderItem>, OrderItemPatternsFramework>();

        return services;
    }
}