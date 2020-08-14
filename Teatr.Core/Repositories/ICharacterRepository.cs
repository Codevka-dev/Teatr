using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface ICharacterRepository
    {
        Task<Character> GetAsync(Guid id);
        Task<Character> GetAsync(string name);
        Task<IEnumerable<Character>> BrowseAsync(string name = "");
        Task<Character> AddAsync(Character character);
        Task<Character> UpdateAsync(Character character);
        Task<Character> DeleteAsync(Character character);
    }
}
