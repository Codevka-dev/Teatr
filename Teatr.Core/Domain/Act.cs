using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Act : Entity
    {
        public Guid dramaId { get; protected set; }

        private ISet<Scene> _scenes = new HashSet<Scene>();
        public string StageDirections { get; protected set; }
        public string Description { get; protected set; }
        public int Number { get; protected set; }
        public string Title { get; protected set; }
        public IEnumerable<Scene> Acts => _scenes;

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

        public void AddScene(string stageDirections, string description, int number, string title)
        {
            _scenes.Add(new Scene(this, stageDirections, description, number, title));
        }

    }
}
