using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services
{
    public interface ISentenceService
    {
        Task<SentenceDto> GetAsync(Guid id);
        Task CreateAsync(Guid id, Guid sceneId, Guid characterId,string text);
        Task AddCharacterAsync(Guid SentenceId, string name, int age, string description);
        Task UpdateAsync(Guid id, Guid sceneId, Guid characterId, string text);
        Task DeleteAsync(Guid id);
    }
}
