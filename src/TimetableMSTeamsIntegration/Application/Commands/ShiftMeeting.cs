using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class ShiftMeeting : IRequest
    {
        // TODO: put info about meeting to be shifted and to what time
        public ShiftMeeting(Guid meetingId, Guid teamId, DateTime newStartTime)
        {
            MeetingId = meetingId;
            TeamId = teamId;
            NewStartTime = newStartTime;
        }

        public Guid MeetingId{ get; private set; }
        public Guid TeamId{ get; private set; }
        public DateTime NewStartTime{ get; private set; }
    }

    public class ShiftMeetingHandler : IRequestHandler<ShiftMeeting>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public ShiftMeetingHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(ShiftMeeting request, CancellationToken cancellationToken)
        {
            // TODO: implement handling 
            // shift meeting in graph
            // save info about meeting shift in db
            try
            {
                await _graphClient.ShiftMeetingAsync(request.MeetingId, request.TeamId, request.NewStartTime);

                await _integrationRepository.InsertShiftMeetingEventAsync(request.MeetingId, request.TeamId, request.NewStartTime);
            }
            catch(Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}