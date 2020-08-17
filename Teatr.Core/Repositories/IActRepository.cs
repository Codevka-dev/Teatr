using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface IActRepository
    {
        Task<Act> GetAsync(Guid id);
        Task AddAsync(Act Act);
        Task UpdateAsync(Act Act);
        Task DeleteAsync(Act Act);
    }
}
