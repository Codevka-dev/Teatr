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
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;
        public CharacterService(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }
        public async Task<CharacterDetailsDto> GetAsync(Guid id)
        {
            var Character = await _characterRepository.GetAsync(id);

            if (Character == null)
            {
                return null;
            }

            return _mapper.Map<CharacterDetailsDto>(Character);
        }

        public async Task<CharacterDetailsDto> GetAsync(string name)
        {
            var Character = await _characterRepository.GetAsync(name);

            if (Character == null)
            {
                return null;
            }

            return _mapper.Map<CharacterDetailsDto>(Character);
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

        public async Task CreateAsync(Guid id, Guid sentenceId, string name, int age, string description, string gender)
        {
            var Character = await _characterRepository.GetAsync(name);

            if (Character != null)
            {
                throw new Exception("Character already exists");
            }

            Character = new Character(id, sentenceId, name, age, description, gender);

            await _characterRepository.AddAsync(Character);
        }

        public async Task DeleteAsync(Guid id)
        {
            var act = await _characterRepository.GetOrFailAsync(id);
            await _characterRepository.DeleteAsync(act);
        }

        public async Task UpdateAsync(Guid id, string name, int age, string desciption, string gender)
        {
            {
                var character = await _characterRepository.GetOrFailAsync(id);
                character = await _characterRepository.GetAsync(name);

                if (character != null)
                {
                    throw new Exception($"Character : {id} already exists");
                }

                character.UpdateAge(age)
                    .UpdateDescription(desciption)
                    .UpdateGender(gender)
                    .UpdateName(name);


                await _characterRepository.UpdateAsync(character);
            }
        }
    }
}
