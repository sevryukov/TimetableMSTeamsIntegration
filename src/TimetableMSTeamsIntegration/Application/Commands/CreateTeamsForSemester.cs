using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    // depending on current date and time creates teams based on disciplines, divisions, virtual groups, etc.
    public class CreateTeamsForSemester : IRequest { }

    public class CreateTeamsForSemesterHandler : IRequestHandler<CreateTeamsForSemester>
    {
        private readonly ITimetableRepository _timetableRepository;
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public CreateTeamsForSemesterHandler(
            ITimetableRepository timetableRepository,
            IIntegrationRepository teamsRepository,
            IMSGraphClient graphClient)
        {
            _timetableRepository = timetableRepository;
            _integrationRepository = teamsRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CreateTeamsForSemester request, CancellationToken cancellationToken)
        {
            // TODO : implement teams creation for entire semester
            // pick information from ITimetableRepository about teams we need to generate
            // post with some time lag information to MS Graph Server 
            // ! possibly this is the place we need to create some long-running job
            // when team is successfully created post information to service db via ITeamsRepository

            return Unit.Value;
        }
    }
}