using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Drama : Entity
    {
        private ISet<Scene> _acts = new HashSet<Scene>();
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public IEnumerable<Scene> Acts => _acts;
        public Drama(Guid id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
        protected Drama()
        {

        }
        public void AddAct(Drama drama)
        {

        }
    }
}
