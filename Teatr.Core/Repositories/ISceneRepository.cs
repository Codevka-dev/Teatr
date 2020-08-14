using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface ISceneRepository
    {
        Task<Scene> GetAsync(Guid id);
        Task<Scene> GetAsync(int number);
        Task<IEnumerable<Scene>> BrowseAsync(int number = 0);
        Task<Scene> AddAsync(Scene scene);
        Task<Scene> UpdateAsync(Scene scene);
        Task<Scene> DeleteAsync(Scene scene);
    }
}
