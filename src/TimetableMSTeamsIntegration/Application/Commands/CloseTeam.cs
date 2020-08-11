using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CloseTeam : IRequest
    {
        // TODO: put here info about team to be closed
    }

    public class CloseTeamHandler : IRequestHandler<CloseTeam>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public CloseTeamHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CloseTeam request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // delete team via graph api
            // put information about team deletion to db

            return Unit.Value;
        }
    }
}