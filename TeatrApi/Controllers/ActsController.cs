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
        private readonly IActService _ActService;
        public ActsController(IActService ActService)
        {
            _ActService = ActService;
        }

        // GET: api/Act/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var Acts = await _ActService.GetAsync(id);

            return Json(Acts);
        }

        // POST: api/Act
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAct command)
        {
            command.ActId = Guid.NewGuid();

            await _ActService.CreateAsync(command.ActId,command.DramaId,command.ActTitle 
                ,command.ActDescription, command.ActNumber, command.ActStageDirections);

            return Created($"/Acts/{command.ActId}", null);
        }

        public async Task UpdateAsync(Guid id, string title, string author, string description)
        {
            var drama = await _dramaRepository.GetAsync(id);

            if (drama == null)
            {
                throw new Exception($"Drama name : {id} not exists");
            }

            drama = await _dramaRepository.GetAsync(title);

            if (drama != null)
            {
                throw new Exception($"Drama name : {title} already exists");
            }

            await _dramaRepository.UpdateAsync(drama);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
