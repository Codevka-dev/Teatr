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
        Task<Character> GetAsync(string title);
        Task<IEnumerable<Character>> BrowseAsync(string name = "");
        Task AddAsync(Character Character);
        Task UpdateAsync(Character Character);
        Task DeleteAsync(Character Character);
    }
}
