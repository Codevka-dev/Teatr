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
        Task<CharacterDetailsDto> GetAsync(Guid id);
        Task<CharacterDetailsDto> GetAsync(string name);
        Task<IEnumerable<CharacterDto>> BrowseAsync(string name = null);
        Task CreateAsync(Guid id,Guid sentenceId, string name, int age, string description,string gender);

        Task UpdateAsync(Guid id, string name, int age, string desciption, string gender);
        Task DeleteAsync(Guid characterId);
    }
}
