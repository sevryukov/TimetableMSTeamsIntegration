using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateTeam : IRequest
    {
        // TODO: put here info about team to be created
    }

    public class CreateTeamHandler : IRequestHandler<CreateTeam>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public CreateTeamHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CreateTeam request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // create team via graph api
            // put information about team creation to db

            return Unit.Value;
        }
    }
}