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
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;
        public CharacterService(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }
        public async Task<CharacterDto> GetAsync(Guid id)
        {
            var Character = await _characterRepository.GetAsync(id);

            if (Character == null)
            {
                return null;
            }

            return _mapper.Map<CharacterDto>(Character);
        }

        public async Task<CharacterDto> GetAsync(string name)
        {
            var Character = await _characterRepository.GetAsync(name);

            if (Character == null)
            {
                return null;
            }

            return _mapper.Map<CharacterDto>(Character);
        }
        public async Task<IEnumerable<CharacterDto>> BrowseAsync(string name = null)
        {
            var character = await _characterRepository.BrowseAsync(name);

            if (character == null)
            {
                return null;
            }

            return _mapper.Map<IEnumerable<CharacterDto>>(character);
        }

        public async Task AddActorAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Guid id,Guid sentenceId, string name, int age, string description,string gender)
        {
            var Character = await _characterRepository.GetAsync(name);

            if (Character != null)
            {
                throw new Exception("Character already exists");
            }

            Character = new Character(id,sentenceId, name, age,description,gender);

            await _characterRepository.AddAsync(Character);
        }

        public async Task DeleteAsync(CharacterDto Character)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(CharacterDto Character)
        {
            throw new NotImplementedException();
        }
    }
}
