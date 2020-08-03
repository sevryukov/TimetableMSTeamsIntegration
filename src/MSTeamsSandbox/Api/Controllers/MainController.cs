using Microsoft.AspNetCore.Mvc;
using MSTeamsSandbox.Application;
using System.Threading.Tasks;
using MediatR;

namespace MSTeamsSandbox.Api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class MainController : ControllerBase
    {
        // TODO: place methods for calling commands from Application layer
        // TODO: acquire Mediator object via DI in constructor

        private IMediator _mediator;

        public MainController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("plan")]
        public async Task<IActionResult> PlanMeeting(/*place parameters if needed*/)
        {
            // create comand object -> var command = new PlanMeeting(...);
            // var result = await _mediator.Send(command);

            throw new System.NotImplementedException();
        }

        [HttpPost("move")]
        public async Task<IActionResult> MoveMeeting(/*place parameters if needed*/)
        {
            // create comand object -> var command = new MoveMeeting(...);
            // var result = await _mediator.Send(command);

            throw new System.NotImplementedException();
        }
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteMeeting(/*place parameters if needed*/)
        {
            // create comand object -> var command = new DeleteMeeting(...);
            // var result = await _mediator.Send(command);

            throw new System.NotImplementedException();
        }
        [HttpPost("planSPBU")]
        public async Task<IActionResult> PlanSpbuMeeting(/*place parameters if needed*/)
        {
            // create comand object -> var command = new PlanSpbuMeeting(...);
            // var result = await _mediator.Send(command);

            throw new System.NotImplementedException();
        }
        [HttpPost("moveSPBU")]
        public async Task<IActionResult> MoveSpbuMeeting(/*place parameters if needed*/)
        {
            // create comand object -> var command = new MoveSpbuMeeting(...);
            // var result = await _mediator.Send(command);

            throw new System.NotImplementedException();
        }
        [HttpPost("deleteSPBU")]
        public async Task<IActionResult> DeleteSpbuMeeting(/*place parameters if needed*/)
        {
            // create comand object -> var command = new DeleteSpbuMeeting(...);
            // var result = await _mediator.Send(command);

            throw new System.NotImplementedException();
        }
    }
}