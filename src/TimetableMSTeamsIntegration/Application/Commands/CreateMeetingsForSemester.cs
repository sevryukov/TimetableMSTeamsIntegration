using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateMeetingsForSemester : IRequest { }

    public class CreateMeetingsForSemesterHandler : IRequestHandler<CreateMeetingsForSemester>
    {
        // main service repository
        private readonly IEventRepository _integrationRepository;
        private readonly ITimetableRepository _timetableRepository;
        private readonly IMSGraphClient _grahpClient;

        public CreateMeetingsForSemesterHandler(
            IEventRepository repository,
            ITimetableRepository timetableRepository,
            IMSGraphClient grahpClient)
        {
            _integrationRepository = repository;
            _timetableRepository = timetableRepository;
            _grahpClient = grahpClient;
        }

        public async Task<Unit> Handle(CreateMeetingsForSemester request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // get information about meetings (maybe not flatten, but rules they should be generated) binded to Teams in terms of Timetable
            // get information about teams
            // create meeting via Graph Client
            // put information about meeting creation to 

            return Unit.Value;
        }
    }
}