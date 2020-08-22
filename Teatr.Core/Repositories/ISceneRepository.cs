using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;

namespace Teatr.Core.Repositories
{
    public interface ISceneRepository
    {
        Task<Scene> GetAsync(int number);
        Task<Scene> GetAsync(Guid id);
        Task AddAsync(Scene Scene);
        Task UpdateAsync(Scene Scene);
        Task DeleteAsync(Scene Scene);
    }
}
