using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Application.Commands
{
    public class DeleteSpbuMeeting : IRequest
    {

    }

    public class DeleteSpbuMeetingHandler : IRequestHandler<DeleteSpbuMeeting>
    {
        public Task<Unit> Handle(DeleteSpbuMeeting request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}