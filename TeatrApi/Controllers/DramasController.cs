﻿using System;
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
    public class DramasController : Controller
    {
        private readonly IDramaService _dramaService;
        public DramasController(IDramaService dramaService)
        {
            _dramaService = dramaService;
        }

        // GET: api/Drama/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dramas = await _dramaService.GetAsync(id);

            return Json(dramas);
        }

        [HttpGet("{title}", Name = "Get")]
        public async Task<IActionResult> Get(string title)
        {
            var dramas = await _dramaService.BrowseAsync(title);

            return Json(dramas);
        }

        // POST: api/Drama
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDrama command)
        {
            command.DramaId = Guid.NewGuid();

            await _dramaService.CreateAsync(command.DramaId, command.Title, command.Author,
                command.Description);

            return Created($"/dramas/{command.DramaId}", null);
        }

        [HttpPut("{dramaId}")]
        public async Task<IActionResult> Put(Guid dramaId,[FromBody] UpdateDrama command)
        {
            await _dramaService.UpdateAsync(dramaId, command.Title,
                command.Author, command.Description);

            return NoContent();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{dramaId}")]
        public async Task<IActionResult> Delete(Guid dramaId)
        {
            await _dramaService.DeleteAsync(dramaId);

            return NoContent();
        }
    }
}
