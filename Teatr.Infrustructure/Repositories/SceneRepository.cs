using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrastructure.Repositories
{
    public class SceneRepository : ISceneRepository
    {
    
        protected static readonly ISet<Scene> _scenes = new HashSet<Scene>();
        public async Task AddAsync(Scene Scene)
        {
            _scenes.Add(Scene);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Scene Scene)
        {
            _scenes.Remove(Scene);
            await Task.CompletedTask;
        }

        public async Task<Scene> GetAsync(Guid id) =>
            await Task.FromResult(_scenes.SingleOrDefault(x => x.Id == id));

        public async Task<Scene> GetAsync(int number) =>
              await Task.FromResult(_scenes.SingleOrDefault(x => x.Number == number));

        public async Task UpdateAsync(Scene Scene)
        {
            throw new NotImplementedException();
        }
    }
}
