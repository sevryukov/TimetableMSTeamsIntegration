using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateMeeting : IRequest
    {
        public CreateMeeting(Guid meetingId, Guid teamId)
        {
            MeetingId = meetingId;
            TeamId = teamId;
        }

        public Guid MeetingId{ get; private set; }
        public Guid TeamId{ get; private set; }
    }

    public class CreateMeetingHandler : IRequestHandler<CreateMeeting>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _grahpClient;

        public CreateMeetingHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient grahpClient)
        {
            _integrationRepository = integrationRepository;
            _grahpClient = grahpClient;
        }

        public async Task<Unit> Handle(CreateMeeting request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // based on request info post information about meeting creation in MS Teams
            // save information on meeting in service database
            try
            {
                await _grahpClient.CreateMeetingAsync(request.MeetingId, request.TeamId);

                await _integrationRepository.CreateMeetingAsync(request.MeetingId, request.TeamId);
            }
            catch(Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}