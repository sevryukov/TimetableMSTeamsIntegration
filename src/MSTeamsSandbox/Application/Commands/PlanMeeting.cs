using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Application.Commands
{
    public class PlanMeeting : IRequest
    {

    }

    public class PlanMeetingHandler : IRequestHandler<PlanMeeting>
    {
        public Task<Unit> Handle(PlanMeeting request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}