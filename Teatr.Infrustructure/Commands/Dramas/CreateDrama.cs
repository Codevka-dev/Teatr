using System;
using System.Collections.Generic;
using System.Text;
using Teatr.Core.Domain;

namespace Teatr.Infrastructure.Commands.Dramas
{
    public class CreateDrama
    {
        public Guid DramaId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

    }
}

