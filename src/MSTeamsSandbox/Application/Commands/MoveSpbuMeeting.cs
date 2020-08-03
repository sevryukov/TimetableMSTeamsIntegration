using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Application.Commands
{
    public class MoveSpbuMeeting : IRequest
    {

    }

    public class MoveSpbuMeetingHandler : IRequestHandler<MoveSpbuMeeting>
    {
        public Task<Unit> Handle(MoveSpbuMeeting request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}