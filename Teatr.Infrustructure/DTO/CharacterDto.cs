using System;
using System.Collections.Generic;
using System.Text;
using Teatr.Core.Domain;

namespace Teatr.Infrastructure.DTO
{
    public class CharacterDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
    }
}
