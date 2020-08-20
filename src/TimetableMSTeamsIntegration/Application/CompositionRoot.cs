using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace TimetableMSTeamsIntegration.Application
{
    public static class CompositionRoot
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CompositionRoot).Assembly);

            return services;
        }
    }
}
