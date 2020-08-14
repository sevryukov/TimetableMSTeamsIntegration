using System.Threading;
using System.Threading.Tasks;
using System;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class RemoveMemberFromTeam : IRequest
    {
        // TODO: put info about which member and from which team we should remove
        public RemoveMemberFromTeam(Guid memberId, Guid teamId)
        {
            MemberId = memberId;
            TeamId = teamId;
        }
        public Guid MemberId{ get; private set; }
        public Guid TeamId{ get; private set; }
    }

    public class RemoveMemberFromTeamHandler : IRequestHandler<RemoveMemberFromTeam>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public RemoveMemberFromTeamHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(RemoveMemberFromTeam request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // post to graph
            // save information about deletion to service database
            try
            {
                await _graphClient.RemoveMemberAsync(request.MemberId, request.TeamId);

                await _integrationRepository.CreateRemoveMemberEventAsync(request.MemberId, request.TeamId);
                //TODO: update delection for many members
            }
            catch(Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}