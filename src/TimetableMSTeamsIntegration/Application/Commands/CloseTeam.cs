using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CloseTeam : IRequest
    {
        public CloseTeam(Guid teamId)
        {
            TeamId = teamId;
        }
        public Guid TeamId{ get; private set; }

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
            try
            {
                await _graphClient.InsertCloseTeamEventAsync(request.TeamId);

                await _integrationRepository.InsertCloseTeamEventAsync(request.TeamId);
            }
            catch(Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}