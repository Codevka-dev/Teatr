using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrastructure.Repositories
{
    public class SentenceRepository : ISentenceRepository
    {
        protected static readonly ISet<Sentence> _sentences = new HashSet<Sentence>();
        public async Task AddAsync(Sentence Sentence)
        {
            _sentences.Add(Sentence);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Sentence Sentence)
        {
            _sentences.Remove(Sentence);
            await Task.CompletedTask;
        }

        public async Task<Sentence> GetAsync(Guid id) =>
            await Task.FromResult(_sentences.SingleOrDefault(x => x.Id == id));

        public async Task UpdateAsync(Sentence Sentence)
        {
            throw new NotImplementedException();
        }
    }
}
