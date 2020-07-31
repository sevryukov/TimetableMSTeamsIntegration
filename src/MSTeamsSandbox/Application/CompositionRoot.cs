using System;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace MSTeamsSandbox.Application
{
    public static class CompositionRoot
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services
                .AddSingleton<CreateTeamService>()
                .AddMediatR(typeof(CompositionRoot).Assembly);
        }
    }
}
