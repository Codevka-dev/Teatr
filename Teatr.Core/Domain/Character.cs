using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Character : Entity
    {
        public Guid actorId { get; protected set; }

        private ISet<User> _actors = new HashSet<User>();
        public IEnumerable<User> Actors => _actors;
        public string Name { get; protected set; }
        public string Age { get; protected set; }
        public string Gender { get; protected set; }
        public string Description { get; protected set; }

        public Character(Sentence sentence, string name, string age, string desciption)
        {
            Id = sentence.Id;
            Name = name;
            Age = age;
            Description = desciption;
        }

        protected Character()
        {

        }
    }
}
