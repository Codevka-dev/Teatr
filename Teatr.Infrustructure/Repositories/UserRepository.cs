using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly ISet<User> _users = new HashSet<User>();
        public async Task AddAsync(User User)
        {
            _users.Add(User);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(User User)
        {
            _users.Remove(User);
            await Task.CompletedTask;
        }

        public async Task<User> GetAsync(Guid id)
            => await Task.FromResult(_users.SingleOrDefault(x => x.Id == id));

        public async Task<User> GetAsync(string email)
            => await Task.FromResult(_users.SingleOrDefault(x => x.Email.ToLower() == email.ToLower()));

        public async Task<IEnumerable<User>> BrowseAsync(string email = "")
        {
            var Users = _users.AsEnumerable();

            if (string.IsNullOrWhiteSpace(email))
            {
                Users = Users.Where(x => x.Email.ToLower()
                .Contains(email.ToLower()));
            }

            return await Task.FromResult(Users);
        }
        public async Task UpdateAsync(User User)
        {
            await Task.CompletedTask;
        }
    }
}

