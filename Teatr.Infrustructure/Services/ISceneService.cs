using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services
{
    public interface ISceneService
    {
        Task<SceneDto> GetAsync(Guid id);
        Task<SceneDto> GetAsync(string title);
        Task<IEnumerable<SceneDto>> BrowseAsync(string title = null);
        Task CreateAsync(Guid id, string title, string author, string description);
        Task AddActAsync(Guid SceneId, string title, string stageDirections, string description, int number);
        Task UpdateAsync(SceneDto Scene);
        Task DeleteAsync(SceneDto Scene);
    }
}
