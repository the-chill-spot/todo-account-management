using Microsoft.OpenApi.Models;

namespace TheChillSpot.Todo.AccountManagement.API.Extensions;

public static class SwaggerExtensions
{
    /// <summary>
    /// Adds the Swagger Generator to the <see cref="IServiceCollection"/> and configures said service with
    /// details specific to this application.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> onto which the Swagger Generation service is added.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddAndConfigureSwaggerDoc(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
            options.SwaggerDoc(ApiConstants.Version, new OpenApiInfo
            {
                Version = ApiConstants.Version,
                Title = ApiConstants.Title,
                Description = ApiConstants.Description,
                TermsOfService = new Uri(ApiConstants.TermsOfServiceUrl),
                Contact = new OpenApiContact
                {
                    Name = ApiConstants.ContactName,
                    Url = new Uri(ApiConstants.ContactUrl)
                },
                License = new OpenApiLicense
                {
                    Name = ApiConstants.LicenseName,
                    Url = new Uri(ApiConstants.LicenseUrl)
                }
            })
        );

        return services;
    }
}
