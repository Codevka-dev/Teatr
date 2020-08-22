using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface ISentenceRepository
    {
        Task<Sentence> GetAsync(Guid id);
        Task AddAsync(Sentence Sentence);
        Task UpdateAsync(Sentence Sentence);
        Task DeleteAsync(Sentence Sentence);
    }
}
