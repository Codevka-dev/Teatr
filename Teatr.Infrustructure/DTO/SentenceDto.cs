using System;
using System.Collections.Generic;
using System.Text;
using Teatr.Core.Domain;

namespace Teatr.Infrastructure.DTO
{
    public class SentenceDto
    {
        public Guid SceneId { get; protected set; }
        public string Text { get; set; }
    }
}
