using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface IDramaRepository
    {
        Task<Drama> GetAsync(Guid id);
        Task<Drama> GetAsync(string title);
        Task<IEnumerable<Drama>> BrowseAsync(string title = "");
        Task AddAsync(Drama drama);
        Task UpdateAsync(Drama drama);
        Task DeleteAsync(Drama drama);
    }
}
