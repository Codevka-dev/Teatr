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
        Task<CharacterDto> GetAsync(string name);
        Task<IEnumerable<CharacterDto>> BrowseAsync(string name = null);
        Task CreateAsync(Guid id,Guid sentenceId, string name, int age, string description,string gender);
        Task AddActor(Guid userId);
        Task UpdateAsync(CharacterDto Character);
        Task DeleteAsync(CharacterDto Character);
    }
}
