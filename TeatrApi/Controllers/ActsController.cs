using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teatr.Infrastructure.Commands.Acts;
using Teatr.Infrastructure.Commands.Dramas;
using Teatr.Infrastructure.Services;

namespace TeatrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActsController : Controller
    {
        private readonly IActService _actService;
        public ActsController(IActService ActService)
        {
            _actService = ActService;
        }

        // GET: api/Act/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var Acts = await _actService.GetAsync(id);

            return Json(Acts);
        }

        // POST: api/Act
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAct command)
        {
            command.ActId = Guid.NewGuid();

            await _actService.CreateAsync(command.ActId, command.DramaId, command.ActTitle
                , command.ActDescription, command.ActNumber, command.ActStageDirections);

            return Created($"/Acts/{command.ActId}", null);
        }
        [HttpPut("{actId}")]
        public async Task<IActionResult> Put(Guid actId, [FromBody] UpdateAct command)
        {
            await _actService.UpdateAsync(actId, command.DramaId, command.ActTitle,
                command.ActDescription, command.ActNumber, command.ActStageDirections);

            return NoContent();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{actId}")]
        public async Task<IActionResult> Delete(Guid actId)
        {
            await _actService.DeleteAsync(actId);

            return NoContent();
        }
    }
}


