using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services
{
    public interface IActService
    {
        Task<ActDto> GetAsync(Guid id);
        Task<ActDto> GetAsync(int number);
        Task CreateAsync(Guid id, Guid dramaId, string title, string description, int number, string stageDirections);
        Task AddSceneAsync(Guid SceneId, string title, string stageDirections, string description, int number);
        Task UpdateAsync(ActDto Act);
        Task DeleteAsync(ActDto Act);
    }
}
