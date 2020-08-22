using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.Commands.Characters
{
    public class CreateCharacter
    {
        public Guid SentenceId { get; set; }
        public Guid CharacterId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
    }
}
