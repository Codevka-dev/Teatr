using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.Commands.Dramas
{
    public class UpdateDrama
    {
        public Guid DramaId { get; set; }
        public string StageDirections { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
