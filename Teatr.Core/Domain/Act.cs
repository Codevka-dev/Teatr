using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Act : Entity
    {
        public Guid DramaId { get; protected set; }

        private ISet<Scene> _scenes = new HashSet<Scene>();
        public string StageDirections { get; protected set; }
        public string Description { get; protected set; }
        public int Number { get; protected set; }
        public string Title { get; protected set; }
        public IEnumerable<Scene> Acts => _scenes;

        public Act(Guid id,Guid dramaId, string stageDirections, string descritpion, int number, string title)
        {
            Id = id;
            DramaId = dramaId;
            StageDirections = stageDirections;
            Description = descritpion;
            Number = number;
            Title = title;
        }

        protected Act()
        {

        }

        public Act UpdateDramaId(Guid dramaId)
        {
            DramaId = dramaId;

            return this;
        }

        public Act UpdateStageDirections(string stageDirections)
        {
            StageDirections = stageDirections;

            return this;
        }

        public Act UpdateDescription(string description)
        {
            Description = description;

            return this;
        }

        public Act UpdateNumber(int number)
        {
            Number = number;

            return this;
        }

        public Act UpdateTitle(string title)
        {
            Title = title;

            return this;
        }

    }
}
