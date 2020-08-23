using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.Commands.Scene
{
    public class UpdateScene
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
