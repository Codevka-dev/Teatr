using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Scene
    {
        public Guid ActId { get; protected set; }

        private ISet<Sentence> _sentences = new HashSet<Sentence>();
        public string StageDirections { get; protected set; }
        public string Description { get; protected set; }
        public int Number { get; protected set; }
        public string Title { get; protected set; }
        public IEnumerable<Sentence> Sentence => _sentences;
        public Scene(string stageDirections, string desciption, int number, string title)
        {
            StageDirections = stageDirections;
            Description = desciption;
            Number = number;
            Title = title;
        }

        protected Scene()
        {

        }
    }
}
