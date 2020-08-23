using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.DTO
{
    public class ActDetailsDto:ActDto
    {
        IEnumerable<SceneDto> Scenes { get; set; }
    }
}
