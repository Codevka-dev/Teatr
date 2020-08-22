using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teatr.Infrastructure.Commands.Dramas;
using Teatr.Infrastructure.Services;

namespace TeatrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScenesController : Controller
    {
        private readonly ISceneService _sceneService;
        public ScenesController(ISceneService dramaService)
        {
            _sceneService = dramaService;
        }

        // GET: api/Drama/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dramas = await _sceneService.GetAsync(id);

            return Json(dramas);
        }


        // POST: api/Drama
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateScene command)
        {
            command.SceneId = Guid.NewGuid();

            await _sceneService.CreateAsync(command.ActId,command.SceneId, command.StageDirections,command.Description,
                command.Number, command.Title);

            return Created($"/scenes/{command.SceneId}", null);
        }

        // PUT: api/Drama/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
