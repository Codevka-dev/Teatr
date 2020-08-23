using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services
{
    public interface IDramaService
    {
        Task<DramaDetailsDto> GetAsync(Guid id);
        Task<DramaDetailsDto> GetAsync(string title);
        Task<IEnumerable<DramaDto>> BrowseAsync(string title = null);
        Task CreateAsync(Guid id, string title, string author, string description);
        Task AddActAsync(Guid id, string title, string stageDirections, string description, int number);
        Task UpdateAsync(Guid id, string title, string author, string description);
        Task DeleteAsync(Guid id);
    }
}
