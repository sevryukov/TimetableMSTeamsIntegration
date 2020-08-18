using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateMeeting : IRequest
    {
        public CreateMeeting(string subject, DateTimeTimeZone start, DateTimeTimeZone end, List<Attendee> аttendees)
        {
            Subject = subject;
            Start = start;
            End = end;
            Attendees = attendees;
        }

        public string Subject{ get; private set; }
        public DateTimeTimeZone Start{ get; private set; }
        public DateTimeTimeZone End{ get; private set; }
        public List<Attendee> Attendees { get; private set;}
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
                await _grahpClient.CreateMeetingAsync(request.Subject, request.Start, request.End, request.Attendees);

                await _integrationRepository.InsertCreateMeetingEventAsync(request.Subject, request.Start, request.End, request.Attendees);
            }
            catch(Exception e)
            {
                throw e;
            }

            return Unit.Value;
        }
    }
}