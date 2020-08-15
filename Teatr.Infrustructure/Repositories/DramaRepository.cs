using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrustructure.Repositories
{
    public class DramaRepository : IDramaRepository
    {
        private static readonly ISet<Drama> _dramas = new HashSet<Drama>();
        public async Task AddAsync(Drama drama)
        {
            _dramas.Add(drama);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Drama drama)
        {
            _dramas.Remove(drama);
            await Task.CompletedTask;
        }

        public async Task<Drama> GetAsync(Guid id)
            => await Task.FromResult(_dramas.SingleOrDefault(x => x.Id == id));

        public async Task<Drama> GetAsync(string title)
            => await Task.FromResult(_dramas.SingleOrDefault(x => x.Title.ToLower() == title.ToLower()));

        public async Task<IEnumerable<Drama>> BrowseAsync(string title = "")
        {
            var dramas = _dramas.AsEnumerable();

            if (string.IsNullOrWhiteSpace(title))
            {
                dramas = dramas.Where(x => x.Title.ToLower()
                .Contains(title.ToLower()));
            }

            return await Task.FromResult(dramas);
        }
        public async Task UpdateAsync(Drama drama)
        {
            await Task.CompletedTask;
        }
    }
}
