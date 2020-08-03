using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Application.Commands
{
    public class PlanSpbuMeeting : IRequest
    {

    }

    public class PlanSpbuMeetingHandler : IRequestHandler<PlanSpbuMeeting>
    {
        public Task<Unit> Handle(PlanSpbuMeeting request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}