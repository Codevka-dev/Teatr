﻿using AutoMapper;
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
        })
            .CreateMapper();

    }
}