using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureDependencies
{
    /// <summary>
    /// Adds Infrastructure layer specific dependencies to the application's <see cref="IServiceCollection"/> instance.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> instance onto which Infrastructure layer dependencies are added.</param>
    /// <param name="configuration">The <see cref="IConfiguration"/> instance, which contains a key/value collection of configuration values.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
