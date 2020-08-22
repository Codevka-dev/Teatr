using System;
using System.Collections.Generic;
using System.Text;
using Teatr.Core.Domain;

namespace Teatr.Infrastructure.Commands.Dramas
{
    public class CreateScene
    {
        public Guid ActId { get; set; }
        public Guid SceneId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string StageDirections { get; set; }
        public int Number { get; set; }
    }
}

