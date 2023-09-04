using Microsoft.Extensions.DependencyInjection;

namespace Services;

public static class DependencyInjection
{
    public static IServiceCollection AddServiceLayer(this IServiceCollection services)
    {
        return services;
    }
}