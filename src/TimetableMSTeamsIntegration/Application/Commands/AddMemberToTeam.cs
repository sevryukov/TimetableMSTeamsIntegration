using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using System;
using TimetableMSTeamsIntegration.Domain.Entities.Events;
using TimetableMSTeamsIntegration.Domain;

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
        public MemberRole Role { get; set; }
    }

    public class AddMemberToTeamHandler : IRequestHandler<AddMemberToTeam>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMSGraphClient _graphClient;

        public AddMemberToTeamHandler(
            IEventRepository eventRepository,
            IMSGraphClient graphClient)
        {
            _eventRepository = eventRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(AddMemberToTeam request, CancellationToken cancellationToken)
        {
            try
            {
                // adding member to MS Team via Graph Client
                await _graphClient.AddMemberAsync(
                    memberId: request.MemberId,
                    teamId: request.TeamId,
                    role: request.Role
                );

                // create event
                var @event = new MemberAddedEvent()
                {
                    UserId = request.MemberId,
                    TeamId = request.TeamId,
                    UserRole = request.Role
                };

                // insert event into repo
                await _eventRepository.InsertAsync(@event);
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