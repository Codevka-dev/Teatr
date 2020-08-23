using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Sentence : Entity
    {
        public Guid SceneId { get; protected set; }
        public Guid CharacterId { get; protected set; }
        private ISet<Character> _characters = new HashSet<Character>();
        public IEnumerable<Character> Characters => _characters;
        public string Text { get; set; }

        public Sentence(Guid id,Guid sceneId,Guid characterId, string text)
        {
            Id = id;
            SceneId = sceneId;
            CharacterId = characterId;
            SceneId = sceneId;
            Text = text;
        }
        protected Sentence()
        {

        }

        public Sentence UpdateSceneId(Guid sceneId)
        {
            SceneId = sceneId;

            return this;
        }

        public Sentence UpdateCharacterId(Guid characterId)
        {
            CharacterId = characterId;

            return this;
        }

        public Sentence UpdateText(string text)
        {
            Text = text;

            return this;
        }
    }
}
