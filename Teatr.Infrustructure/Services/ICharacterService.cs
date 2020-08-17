using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services
{
    public interface ICharacterService
    {
        Task<CharacterDto> GetAsync(Guid id);
        Task<CharacterDto> GetAsync(string title);
        Task<IEnumerable<CharacterDto>> BrowseAsync(string title = null);
        Task CreateAsync(Guid id, string name, string age, string description);
        Task AddActAsync(Guid CharacterId, string title, string stageDirections, string description, int number);
        Task UpdateAsync(CharacterDto Character);
        Task DeleteAsync(CharacterDto Character);
    }
}
