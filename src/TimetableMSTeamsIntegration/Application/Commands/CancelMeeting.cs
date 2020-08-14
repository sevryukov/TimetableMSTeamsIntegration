using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using TimetableMSTeamsIntegration.Domain.Entities;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.MeetingAggregates;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CancelMeeting : IRequest
    {
        // TODO: put here information required for identifying meeting
        public CancelMeeting(Guid meetingId, Guid teamId)
        {
            MeetingId = meetingId;
            TeamId = teamId;
        }
        public Guid MeetingId{ get; private set; } 
        public Guid TeamId{ get; private set; } 
    } 

    public class CancelMeetingHandler : IRequestHandler<CancelMeeting>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public CancelMeetingHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CancelMeeting request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // from command get information about meeting to be changed
            // cancel it via graph
            // after successfull cancellation post event to database 
            try
            {
                await _graphClient.CancelMeetingAsync(request.MeetingId, request.TeamId);
                
                await _integrationRepository.CancelMeetingAsync(request.MeetingId, request.TeamId);
            }
            catch(Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}