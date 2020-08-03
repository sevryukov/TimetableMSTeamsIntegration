using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Application.Commands
{
    public class DeleteMeeting : IRequest
    {

    }

    public class DeleteMeetingHandler : IRequestHandler<DeleteMeeting>
    {
        public Task<Unit> Handle(DeleteMeeting request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}