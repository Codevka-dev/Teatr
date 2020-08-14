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
        Task<Drama> AddAsync(Drama drama);
        Task<Drama> UpdateAsync(Drama drama);
        Task<Drama> DeleteAsync(Drama drama);
    }
}
