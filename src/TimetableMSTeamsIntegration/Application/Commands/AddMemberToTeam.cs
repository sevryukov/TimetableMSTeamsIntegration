using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using Microsoft.Graph;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class AddMemberToTeam : IRequest
    {
        // TODO: put here information about member and team
    }

    public class AddMemberToTeamHandler : IRequestHandler<AddMemberToTeam>
    {

        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public AddMemberToTeamHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(AddMemberToTeam request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // get info about what member (ms id) we want to add to which team (ms id) and post this info in graph
            // post info about adding member to service db

            return Unit.Value;
        }
    }
}