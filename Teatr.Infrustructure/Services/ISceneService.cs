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
        Task<SceneDto> GetAsync(int number);
        Task CreateAsync(Guid id, Guid actId, string stageDirections, string desciption, int number, string title);
        Task UpdateAsync(SceneDto Scene);
        Task DeleteAsync(SceneDto Scene);
    }
}
