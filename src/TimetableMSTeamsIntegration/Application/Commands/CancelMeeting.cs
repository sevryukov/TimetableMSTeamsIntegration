using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using TimetableMSTeamsIntegration.Common.Application;
using TimetableMSTeamsIntegration.Domain.Entities.Events;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CancelMeeting : IRequest
    {
        public CancelMeeting(Guid meetingId)
        {
            MeetingId = meetingId;

        }
        public Guid MeetingId { get; private set; }
        public Guid TeamId { get; set; }

    }

    public class CancelMeetingHandler : IRequestHandler<CancelMeeting>
    {
        private readonly IRepository<MeetingCanceledEvent, Guid> _eventRepository;
        private readonly IMSGraphClient _graphClient;

        public CancelMeetingHandler(
            IRepository<MeetingCanceledEvent, Guid> eventRepository,
            IMSGraphClient graphClient)
        {
            _eventRepository = eventRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CancelMeeting request, CancellationToken cancellationToken)
        {
            try
            {
                await _graphClient.CancelMeetingAsync(request.MeetingId);

                var @event = new MeetingCanceledEvent()
                {
                    TeamId = request.TeamId,
                    MeetingId = request.MeetingId
                }


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