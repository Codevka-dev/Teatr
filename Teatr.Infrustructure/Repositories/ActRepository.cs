using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrastructure.Repositories
{
    public class ActRepository : IActRepository
    {
        protected static readonly ISet<Act> _acts = new HashSet<Act>();
        public async Task AddAsync(Act Act)
        {
             _acts.Add(Act);
             await Task.CompletedTask;
        }

        public async Task DeleteAsync(Act Act)
        {
            _acts.Remove(Act);
            await Task.CompletedTask;
        }

        public async Task<Act> GetAsync(Guid id) =>     
            await Task.FromResult(_acts.SingleOrDefault(x => x.Id == id));

        public async Task UpdateAsync(Act Act)
        {
            throw new NotImplementedException();
        }
    }
}
