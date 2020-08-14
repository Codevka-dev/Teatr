using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string name);
        Task<IEnumerable<User>> BrowseAsync(string name = "");
        Task<User> AddAsync(User scene);
        Task<User> UpdateAsync(User scene);
        Task<User> DeleteAsync(User scene);
    }
}
