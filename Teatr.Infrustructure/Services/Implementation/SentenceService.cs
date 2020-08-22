using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;
using Teatr.Infrastructure.DTO;

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

        public async Task DeleteAsync(SentenceDto Sentence)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(SentenceDto Sentence)
        {
            throw new NotImplementedException();
        }

        public Task AddCharacterAsync(Guid SentenceId, string name, int age, string description)
        {
            _sentenceRepository.
        }
    }
}
