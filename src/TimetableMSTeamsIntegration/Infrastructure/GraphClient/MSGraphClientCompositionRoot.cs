using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Infrastructure.GraphClient
{
    public static class MSGraphClientCompositionRoot
    {
        public static IServiceCollection AddGraphClient(this IServiceCollection services, IConfiguration configuration)
        {
            var CGCAPConfig = new ConfidentialGraphClientAuthenticationProviderConfiguration();
            configuration.Bind("GraphClient", CGCAPConfig);

            // register pure graphClient
            services.AddSingleton(provider =>
            {
                var authProvider = new ConfidentialGraphClientAuthenticationProvider(CGCAPConfig);

                return new GraphServiceClient(authProvider);
            });

            // register graph client wrapper
            services.AddSingleton<IMSGraphClient, MSGraphClient>();

            return services;
        }
    }
}