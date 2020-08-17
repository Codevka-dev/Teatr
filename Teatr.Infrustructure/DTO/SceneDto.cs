using System;
using System.Collections.Generic;
using System.Text;
using Teatr.Core.Domain;

namespace Teatr.Infrastructure.DTO
{
    public class SceneDto
    {
        public Guid Id { get; set; }
        public string StageDirections { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
    }
}
