using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Repositories;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Services.Implementation
{
    public class DramaService : IDramaService
    {
        private readonly IDramaRepository _dramaRepository;
        private readonly IMapper _mapper;
        public DramaService(IDramaRepository dramaRepository, IMapper mapper)
        {
            _dramaRepository = dramaRepository;
            _mapper = mapper;
        }
        public async Task<DramaDto> GetAsync(Guid id)
        {
            var drama = await _dramaRepository.GetAsync(id);

            if (drama == null)
            {
                return null;
            }

            return _mapper.Map<DramaDto>(drama);
        }

        public async Task<DramaDto> GetAsync(string title)
        {
            var drama = await _dramaRepository.GetAsync(title);

            if (drama == null)
            {
                return null;
            }

            return _mapper.Map<DramaDto>(drama);
        }
        public async Task<IEnumerable<DramaDto>> BrowseAsync(string title = null)
        {
            var drama = await _dramaRepository.BrowseAsync(title);

            if (drama == null)
            {
                return null;
            }

            return _mapper.Map<IEnumerable<DramaDto>>(drama);
        }
        public async Task AddActAsync(Guid dramaId, string title, string stageDirections, string description, int number)
        {
            throw new NotImplementedException();
        }
        public async Task CreateAsync(Guid id, string title, string stageDirections, string description, int number)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(DramaDto drama)
        {
            throw new NotImplementedException();
        }



        public async Task UpdateAsync(DramaDto drama)
        {
            throw new NotImplementedException();
        }
    }
}
