using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.DTO
{
    public class SceneDetailsDto:SceneDto
    {
        IEnumerable<SentenceDto> Sentences { get; set; } 
    }
}
