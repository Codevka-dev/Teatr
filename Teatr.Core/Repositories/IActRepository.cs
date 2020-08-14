using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    interface IActRepository
    {
        Task<Act> GetAsync(Guid id);
        Task<Act> GetAsync(int number);
        Task<IEnumerable<Act>> BrowseAsync(int number = 0);
        Task<Act> AddAsync(Act act);
        Task<Act> UpdateAsync(Act act);
        Task<Act> DeleteAsync(Act act);
    }
}

