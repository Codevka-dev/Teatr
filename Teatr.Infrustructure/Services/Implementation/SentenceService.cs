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
    public class SentenceService : ISentenceService
    {
        private readonly ISentenceRepository _sentenceRepository;
        private readonly IMapper _mapper;
        public SentenceService(ISentenceRepository sentenceRepository, IMapper mapper)
        {
            _sentenceRepository = sentenceRepository;
            _mapper = mapper;
        }
        public async Task<SentenceDto> GetAsync(Guid id)
        {
            var Sentence = await _sentenceRepository.GetAsync(id);

            if (Sentence == null)
            {
                return null;
            }

            return _mapper.Map<SentenceDto>(Sentence);
        }

        public async Task CreateAsync(Guid id, Guid sceneId, Guid characterId, string text)
        {
            var sentence = new Sentence(id,sceneId,characterId, text);

            await _sentenceRepository.AddAsync(sentence);
        }

        public async Task DeleteAsync(Guid id)
        {
            var sentence = await _sentenceRepository.GetOrFailAsync(id);
            await _sentenceRepository.DeleteAsync(sentence);
        }

        public async Task UpdateAsync(Guid id, Guid sceneId, Guid characterId, string text)
        {
            var sentence = await _sentenceRepository.GetOrFailAsync(id);

            sentence.UpdateSceneId(sceneId)
                .UpdateCharacterId(characterId)
                .UpdateText(text);


            await _sentenceRepository.UpdateAsync(sentence);
        }

        public Task AddCharacterAsync(Guid SentenceId, string name, int age, string description)
        {
            throw new NotImplementedException();
        }
    }
}
