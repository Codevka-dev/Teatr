using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Scene : Entity
    {
        public Guid? ActId { get; protected set; }

        private ISet<Sentence> _sentences = new HashSet<Sentence>();
        public string StageDirections { get; protected set; }
        public string Description { get; protected set; }
        public int Number { get; protected set; }
        public string Title { get; protected set; }
        public IEnumerable<Sentence> Sentence => _sentences;
        public Scene(Guid id,Guid actId, string stageDirections, string desciption, int number, string title)
        {
            Id = id;
            ActId = actId;
            StageDirections = stageDirections;
            Description = desciption;
            Number = number;
            Title = title;
        }

        protected Scene()
        {

        }

        public Scene UpdateActId(Guid actId)
        {
            ActId = actId;

            return this;
        }

        public Scene UpdateStageDirections(string stageDirections)
        {
            StageDirections = stageDirections;

            return this;
        }
        public Scene UpdateDescription(string description)
        {
            Description = description;

            return this;
        }
        public Scene UpdateNumber(int number)
        {
            Number = number;

            return this;
        }
        public Scene UpdateTitle(string title)
        {
            Title = title;

            return this;
        }
    }
}
