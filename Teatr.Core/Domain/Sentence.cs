using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Sentence : Entity
    {
        public Guid SceneId { get; protected set; }
        private ISet<Character> _characters = new HashSet<Character>();
        public IEnumerable<Character> Characters => _characters;
        public string Text { get; set; }

        public Sentence(Scene scene, string text)
        {
            SceneId = scene.Id;
            Text = text;
        }
        protected Sentence()
        {

        }
    }
}
