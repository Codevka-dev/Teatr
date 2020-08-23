using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teatr.Infrastructure.Commands.Characters;
using Teatr.Infrastructure.Commands.Dramas;
using Teatr.Infrastructure.Services;

namespace TeatrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : Controller
    {
        private readonly ICharacterService _characterService;
        public CharactersController(ICharacterService dramaService)
        {
            _characterService = dramaService;
        }

        // GET: api/Drama/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dramas = await _characterService.GetAsync(id);

            return Json(dramas);
        }

        [HttpGet("{title}", Name = "Get")]
        public async Task<IActionResult> Get(string title)
        {
            var dramas = await _characterService.BrowseAsync(title);

            return Json(dramas);
        }

        // POST: api/Drama
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCharacter command)
        {
            command.CharacterId = Guid.NewGuid();

            await _characterService.CreateAsync(command.CharacterId, command.SentenceId, command.Name, command.Age,command.Description,command.Gender);

            return Created($"/characters/{command.CharacterId}", null);
        }

        [HttpPut("{characterId}")]
        public async Task<IActionResult> Put(Guid characterId,[FromBody] UpdateCharacter command)
        {
            await _characterService.UpdateAsync(characterId, command.Name, command.Age,
                command.Description,command.Gender);

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{characterId}")]
        public async Task<IActionResult> Delete(Guid characterId)
        {
            await _characterService.DeleteAsync(characterId);

            return NoContent();
        }
    }
}
