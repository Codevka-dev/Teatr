using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.DTO
{
    public class DramaDetailsDto:DramaDto
    {
        public IEnumerable<ActDto> Acts { get; set; }
    }
}
