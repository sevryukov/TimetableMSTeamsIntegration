using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System;
using TimetableMSTeamsIntegration.Domain.Entities;
using System.Collections.Generic;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateMeeting : IRequest
    {
        public CreateMeeting(string subject, DateTime start, DateTime end, List<Guid> attendees)
        {
            Subject = subject;
            Start = start;
            End = end;
            Attendees = attendees;
            
        }

        public string Subject{ get; private set; }
        public DateTime Start{ get; private set; }
        public DateTime End{ get; private set; }
        public List<Guid> Attendees { get; private set;}
    }
    public class CreateMeetingSecondEdition: IRequest
    {
        public CreateMeetingSecondEdition(string subject, DateTime start, DateTime end, List<TeamMember> attendees)
        {
            Subject = subject;
            Start = start;
            End = end;
            Attendees = attendees;
            
        }

        public string Subject{ get; private set; }
        public DateTime Start{ get; private set; }
        public DateTime End{ get; private set; }
        public List<TeamMember> Attendees { get; private set;}
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

    public class CreateMeetingSecondEditionHandler: IRequestHandler<CreateMeetingSecondEdition>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _grahpClient;
        public CreateMeetingSecondEditionHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient grahpClient)
        {
            _integrationRepository = integrationRepository;
            _grahpClient = grahpClient;
        }
         public async Task<Unit> Handle(CreateMeetingSecondEdition request, CancellationToken cancellationToken)
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
