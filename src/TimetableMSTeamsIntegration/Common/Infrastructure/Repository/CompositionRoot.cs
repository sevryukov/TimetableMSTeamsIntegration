using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace TimetableMSTeamsIntegration.Common.Infrastructure.Repository
{
    public static class CompositionRoot
    {
        public static IServiceCollection AddMSSQLRepositoryConfiguration(
            this IServiceCollection services,
            IConfiguration config)
        {
            var mssqlConfig = new MSSQLRepositoryConfiguration();
            config.Bind("MSSQL", mssqlConfig);

            services.TryAddSingleton<IMSSQLRepositoryConfiguration>(mssqlConfig);

            return services;
        }
    }
}