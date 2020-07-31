using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Application.Commands
{
    public class MoveMeeting : IRequest
    {

    }

    public class MoveMeetingHandler : IRequestHandler<MoveMeeting>
    {
        public Task<Unit> Handle(MoveMeeting request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}