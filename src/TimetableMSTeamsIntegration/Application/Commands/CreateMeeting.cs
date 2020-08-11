using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateMeeting : IRequest
    {
        // TODO: put here information required for creating meeting
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

            return Unit.Value;
        }
    }
}