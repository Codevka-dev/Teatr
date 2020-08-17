using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrastructure.Repositories
{
    class CharacterRepository : ICharacterRepository
    {
        private static readonly ISet<Character> _characters = new HashSet<Character>();
        public async Task AddAsync(Character Character)
        {
            _characters.Add(Character);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Character Character)
        {
            _characters.Remove(Character);
            await Task.CompletedTask;
        }

        public async Task<Character> GetAsync(Guid id)
            => await Task.FromResult(_characters.SingleOrDefault(x => x.Id == id));

        public async Task<Character> GetAsync(string name)
            => await Task.FromResult(_characters.SingleOrDefault(x => x.Name.ToLower() == name.ToLower()));

        public async Task<IEnumerable<Character>> BrowseAsync(string title = "")
        {
            var Characters = _characters.AsEnumerable();

            if (string.IsNullOrWhiteSpace(title))
            {
                Characters = Characters.Where(x => x.Name.ToLower()
                .Contains(title.ToLower()));
            }

            return await Task.FromResult(Characters);
        }
        public async Task UpdateAsync(Character Character)
        {
            await Task.CompletedTask;
        }
    }
}
