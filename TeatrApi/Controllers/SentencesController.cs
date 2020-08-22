using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teatr.Infrastructure.Commands.Dramas;
using Teatr.Infrastructure.Commands.Sentence;
using Teatr.Infrastructure.Services;

namespace TeatrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentencesController : Controller
    {
        private readonly ISentenceService _sentencesService;
        public SentencesController(ISentenceService sentenceService)
        {
            _sentencesService = sentenceService;
        }

        // GET: api/Drama/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dramas = await _sentencesService.GetAsync(id);

            return Json(dramas);
        }

        // POST: api/Drama
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSentence command)
        {
            command.SentenceId = Guid.NewGuid();

            await _sentencesService.CreateAsync(command.SentenceId, command.SceneId, command.CharacterId
                , command.Text);

            return Created($"/sentences/{command.SentenceId}", null);
        }

        // PUT: api/Drama/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CreateSentence command)
        {
            command.SentenceId = Guid.NewGuid();

            await _sentencesService.CreateAsync(command.SentenceId, command.SceneId, command.CharacterId
                , command.Text);

            return Created($"/sentences/{command.SentenceId}", null);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
