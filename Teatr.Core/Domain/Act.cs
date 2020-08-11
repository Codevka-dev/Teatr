using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Act : Entity
    {
        public Guid dramaId { get; protected set; }

        private ISet<Scene> _acts = new HashSet<Scene>();
        public string StageDirections { get; protected set; }
        public string Description { get; protected set; }
        public int Number { get; protected set; }
        public string Title { get; protected set; }
        public IEnumerable<Scene> Acts => _acts;

        public Act(Drama drama, string stageDirections, string descritpion, int number, string title)
        {
            dramaId = drama.Id;
            StageDirections = stageDirections;
            Description = descritpion;
            Number = number;
            Title = title;
        }

        protected Act()
        {

        }
    }
}
