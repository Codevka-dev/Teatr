using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Drama : Entity
    {
        private ISet<Act> _acts = new HashSet<Act>();
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public string Description { get; set; }
        public IEnumerable<Act> Acts => _acts;
        public Drama(Guid id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
        protected Drama()
        {

        }
        public void AddAct(Drama drama, string stageDirections, string description, int number, string title)
        {
            _acts.Add(new Act(this, stageDirections, description, number, title));
        }
    }
}
