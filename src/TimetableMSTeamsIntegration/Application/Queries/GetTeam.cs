using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using TimetableMSTeamsIntegration.Domain.Abstract;
using TimetableMSTeamsIntegration.Domain.Entities;
using System.Linq;

namespace TimetableMSTeamsIntegration.Application.Queries
{
    public class GetTeam : IRequest<Team>
    {
        public GetTeam(Guid teamId) => TeamId = teamId;
        public Guid TeamId { get; private set; }
    }

    public class GetTeamHandler : IRequestHandler<GetTeam, Team>
    {
        public IEventRepository _integrationRepository;
        public async Task<Team> Handle(GetTeam request, CancellationToken cancellationToken)
        {
            var teamAggregates = await _integrationRepository.GetTeamEventsAsync(request.TeamId);

            // ! we should ensure that TeamCreated is first event !!! this is problem !!!
            var team = teamAggregates
                .ToList()
                .Aggregate();

            return team;
        }
    }
}