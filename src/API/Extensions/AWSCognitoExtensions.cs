using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace TheChillSpot.Todo.AccountManagement.API.Extensions;

public static class AWSCognito
{
    /// <summary>
    /// Extension method which adds AWS Cognito related authentication configuration.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> onto which the AWS Cognito configuration is added.</param>
    /// <param name="configuration">The <see cref="IConfiguration"/> instance, which contains a key/value collection of configuration values.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddCognito(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCognitoIdentity();
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.Authority = configuration["AWSCognito:Authority"];
            // options.Audience = configuration["AWSCognito:Audience"];        
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateAudience = false // TODO bavant: We should probably turn this on.
            };
        });

        return services;
    }
}
