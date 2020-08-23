using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;
using Teatr.Infrastructure.DTO;
using Teatr.Infrastructure.Extensions;

namespace Teatr.Infrastructure.Services.Implementation
{
    public class SceneService : ISceneService
    {
        private readonly ISceneRepository _sceneRepository;
        private readonly IMapper _mapper;
        public SceneService(ISceneRepository sceneRepository, IMapper mapper)
        {
            _sceneRepository = sceneRepository;
            _mapper = mapper;
        }
        public async Task<SceneDetailsDto> GetAsync(Guid id)
        {
            var Scene = await _sceneRepository.GetAsync(id);

            if (Scene == null)
            {
                return null;
            }

            return _mapper.Map<SceneDetailsDto>(Scene);
        }

        public async Task<SceneDetailsDto> GetAsync(int number)
        {
            var Scene = await _sceneRepository.GetAsync(number);

            if (Scene == null)
            {
                return null;
            }

            return _mapper.Map<SceneDetailsDto>(Scene);
        }

        public async Task CreateAsync(Guid id,Guid actId, string stageDirections, string desciption, int number, string title)
        {
            var Scene = await _sceneRepository.GetAsync(number);

            if (Scene != null)
            {
                throw new Exception("Scene already exists");
            }

            Scene = new Scene(id,actId,stageDirections,desciption,number,title);

            await _sceneRepository.AddAsync(Scene);
        }

        public async Task DeleteAsync(Guid id)
        {
            var scene = await _sceneRepository.GetOrFailAsync(id);
            await _sceneRepository.DeleteAsync(scene);
        }

        public async Task UpdateAsync(Guid id, Guid actId, string stageDirections, string desciption, int number, string title)
        {
            var scene = await _sceneRepository.GetOrFailAsync(id);
            scene = await _sceneRepository.GetAsync(number);

            if (scene != null)
            {
                throw new Exception($"Scene name : {title} already exists");
            }

            scene.UpdateActId(actId)
                .UpdateDescription(desciption)
                .UpdateNumber(number)
                .UpdateTitle(title)
                .UpdateStageDirections(stageDirections);

            await _sceneRepository.UpdateAsync(scene);
        }
    }
}
