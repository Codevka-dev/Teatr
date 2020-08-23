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

        public Drama UpdateTitle(string title) 
        {
            Title = title;

            return this;
        }
        public Drama UpdateAuthor(string author)
        {
            Author = author;

            return this;
        }
        public Drama UpdateDescription(string description)
        {
            Description = description;

            return this;
        }
    }
}
