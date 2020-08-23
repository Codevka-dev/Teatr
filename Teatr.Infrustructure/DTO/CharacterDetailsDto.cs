using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.DTO
{
    public class CharacterDetailsDto:CharacterDto
    {
        IEnumerable<SentenceDto> Sentences { get; set; }
    }
}
