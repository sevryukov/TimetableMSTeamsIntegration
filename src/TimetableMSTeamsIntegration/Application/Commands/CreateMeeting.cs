using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Domain.Entities;
using System.Collections.Generic;
using TimetableMSTeamsIntegration.Application.Services;
using TimetableMSTeamsIntegration.Domain.Entities.Events;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateMeeting : IRequest
    {
        public CreateMeeting(
            string subject,
            DateTime start,
            DateTime end,
            List<TeamMember> attendees,
            Guid teamId,
            Guid timetableEventId)
            => (Subject, Start, End, Attendees, TeamId, TimetableEventId) =
                (subject, start, end, attendees, teamId, timetableEventId);

        public string Subject { get; private set; }
        public Guid TeamId { get; private set; }
        public Guid TimetableEventId { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public List<TeamMember> Attendees { get; private set; }
    }

    public class CreateMeetingHandler : IRequestHandler<CreateMeeting>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMSGraphClient _graphClient;

        public CreateMeetingHandler(
            IEventRepository eventRepository,
            IMSGraphClient graphClient)
        {
            _eventRepository = eventRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CreateMeeting request, CancellationToken cancellationToken)
        {
            try
            {
                await _graphClient.CreateMeetingAsync(request.Subject, request.Start, request.End, request.Attendees);

                var @event = new MeetingCreatedEvent()
                {
                    TeamId = request.TeamId,
                    TimetableEventId = request.TimetableEventId,
                    Title = request.Subject,
                    StartsAt = request.Start,
                    EndsAt = request.End
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
