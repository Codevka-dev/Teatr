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
        Task<DramaDto> GetAsync(Guid id);
        Task<DramaDto> GetAsync(string title);
        Task<IEnumerable<DramaDto>> BrowseAsync(string title = null);
        Task CreateAsync(Guid id, string title, string stageDirections, string description, int number);
        Task AddActAsync(Guid dramaId, string title, string stageDirections, string description, int number);
        Task UpdateAsync(DramaDto drama);
        Task DeleteAsync(DramaDto drama);
    }
}
