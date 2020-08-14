using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using Microsoft.Graph;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;
using System;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class AddMemberToTeam : IRequest
    {
        public AddMemberToTeam(Guid memberId, Guid teamId)
        {
            MemberId = memberId;
            TeamId = teamId;
        }
        public Guid MemberId { get; private set; }
        public Guid TeamId { get; private set; }
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
            try
            {
                // adding member to MS Team via Graph Client
                await _graphClient.AddMemberAsync(
                    memberId: request.MemberId,
                    teamId: request.TeamId
                );

                // everything is ok => create event in repo that describes that member was added
                await _integrationRepository.CreateAddMemberEventAsync(
                    memberId: request.MemberId,
                    teamId: request.TeamId
                );
            }
            catch (Exception e)
            {
                // ? maybe we need some logging on errors in such situations and there we should put it, 
                // ? via injected (in future) logging service 

                throw e;
            }

            // ok, return

            return Unit.Value;
        }
    }
}