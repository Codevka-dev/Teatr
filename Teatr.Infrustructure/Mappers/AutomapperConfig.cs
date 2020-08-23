using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teatr.Core.Domain;
using Teatr.Infrastructure.DTO;

namespace Teatr.Infrastructure.Mappers
{
    public static class AutomapperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Drama, DramaDto>()
                  .ForMember(x => x.ActsCount, m => m.MapFrom(p => p.Acts.Count()));
            cfg.CreateMap<Act, ActDto>();
            cfg.CreateMap<Scene, SceneDto>();
            cfg.CreateMap<Sentence, SentenceDto>();
            cfg.CreateMap<Character, CharacterDto>();

            cfg.CreateMap<Character, CharacterDetailsDto>();
            cfg.CreateMap<Act, ActDetailsDto>();
            cfg.CreateMap<Scene, SceneDetailsDto>();
            cfg.CreateMap<Drama, DramaDetailsDto>();
        })
            .CreateMapper();

    }
}
