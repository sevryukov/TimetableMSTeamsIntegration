using Microsoft.AspNetCore.Mvc;
using System;
using MSTeamsSandbox.Application;
using System.Threading.Tasks;

namespace MSTeamsSandbox.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateTeamController: ControllerBase
    {
        private CreateTeamService _teamservice;

        public CreateTeamController(CreateTeamService teamService)
                =>_teamservice = teamService;

        [HttpPost("create")]
        public async Task<IActionResult> CreateTeam()
        {
            try
            {
              return Ok(await _teamservice.TryCreateTeam());
                
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }

}