using System;
using Microsoft.Extensions.DependencyInjection;

namespace TimetableMSTeamsIntegration.Infrastructure
{
    public static class CompositionRoot
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // TODO: put here required DI for services - MS Graph, required Databases

            return services;
        }
    }
}
