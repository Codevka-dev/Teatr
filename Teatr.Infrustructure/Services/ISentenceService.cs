using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services
{
    public interface ISentenceService
    {
        Task<SentenceDto> GetAsync(Guid id);
        Task<SentenceDto> GetAsync(string title);
        Task<IEnumerable<SentenceDto>> BrowseAsync(string title = null);
        Task CreateAsync(Guid id, string title, string author, string description);
        Task AddActAsync(Guid SentenceId, string title, string stageDirections, string description, int number);
        Task UpdateAsync(SentenceDto Sentence);
        Task DeleteAsync(SentenceDto Sentence);
    }
}
