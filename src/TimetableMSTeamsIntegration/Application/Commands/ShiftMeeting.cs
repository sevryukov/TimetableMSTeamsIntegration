using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class ShiftMeeting : IRequest
    {
        // TODO: put info about meeting to be shifted and to what time
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

            return Unit.Value;
        }
    }
}