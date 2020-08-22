using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Application.Services;
using TimetableMSTeamsIntegration.Domain.Entities.Events;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CloseTeam : IRequest
    {
        public CloseTeam(Guid teamId)
        {
            TeamId = teamId;
        }
        public Guid TeamId { get; private set; }

    }

    public class CloseTeamHandler : IRequestHandler<CloseTeam>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMSGraphClient _graphClient;

        public CloseTeamHandler(
            IEventRepository eventRepository,
            IMSGraphClient graphClient)
        {
            _eventRepository = eventRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CloseTeam request, CancellationToken cancellationToken)
        {
            try
            {
                await _graphClient.CloseTeamAsync(request.TeamId);

                var @event = new TeamClosedEvent()
                {
                    TeamId = request.TeamId
                };

                await _eventRepository.InsertAsync(@event);
            }
            catch (Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}