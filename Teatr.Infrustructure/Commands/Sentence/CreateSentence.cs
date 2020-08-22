using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Infrastructure.Commands.Sentence
{
    public class CreateSentence
    {
        public Guid SentenceId { get; set; }
        public Guid CharacterId { get;  set; }
        public Guid SceneId { get;  set; }
        public string Text { get; set; }
    }
}
