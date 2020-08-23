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
    public class ActService : IActService
    {
        private readonly IActRepository _actRepository;
        private readonly IMapper _mapper;
        public ActService(IActRepository actRepository, IMapper mapper)
        {
            _actRepository = actRepository;
            _mapper = mapper;
        }
        public async Task<ActDetailsDto> GetAsync(Guid id)
        {
            var Act = await _actRepository.GetAsync(id);

            if (Act == null)
            {
                return null;
            }

            return _mapper.Map<ActDetailsDto>(Act);
        }

        public async Task<ActDetailsDto> GetAsync(int number)
        {
            var Act = await _actRepository.GetAsync(number);

            if (Act == null)
            {
                return null;
            }

            return _mapper.Map<ActDetailsDto>(Act);
        }

        public async Task AddSceneAsync(Guid SceneId, string title, string stageDirections, string description, int number)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Guid id,Guid dramaId, string title, string description,int number,string stageDirections)
        {
            var act = await _actRepository.GetAsync(number);

            if (act != null)
            {
                throw new Exception("Act already exists");
            }

            act = new Act(id , dramaId,stageDirections,description,number, title);

            await _actRepository.AddAsync(act);
        }

        public async Task UpdateAsync(Guid id, Guid dramaId, string title, string description, int number, string stageDirections)
        {
            var act = await _actRepository.GetOrFailAsync(id);     

            act.UpdateDramaId(dramaId)
                .UpdateTitle(title)
                .UpdateDescription(description)
                .UpdateStageDirections(stageDirections)
                .UpdateNumber(number);

            await _actRepository.UpdateAsync(act);
        }

        public async Task DeleteAsync(Guid id)
        {
            var act = await _actRepository.GetOrFailAsync(id);
            await _actRepository.DeleteAsync(act);
        }
    }
}
