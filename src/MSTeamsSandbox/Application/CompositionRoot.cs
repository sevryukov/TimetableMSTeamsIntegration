using System;
using Microsoft.Extensions.DependencyInjection;

namespace MSTeamsSandbox.Application
{
    public static class CompositionRoot
    {
        // TODO: add ConfigureApplication _extension method_ for IServiceCollection which places 
        //       mediator and requests to DI container
        // !     see how it is done in https://www.github.com/dckntm/focus-backend
        // !     do not forget to include MediatR package
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services.AddSingleton<CreateTeamService>();
        }
    }
}
