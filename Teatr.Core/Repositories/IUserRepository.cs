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
        Task<User> GetAsync(string email);
        Task<IEnumerable<User>> BrowseAsync(string email = "");
        Task AddAsync(User scene);
        Task UpdateAsync(User scene);
        Task DeleteAsync(User scene);
    }
}
