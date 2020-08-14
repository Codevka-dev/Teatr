using System;
using System.Collections.Generic;
using System.Text;

namespace Teatr.Core.Domain
{
    public class Character : Entity
    {
        public Guid? ActorId { get; protected set; }

        private ISet<User> _actors = new HashSet<User>();
        public IEnumerable<User> Actors => _actors;
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string Gender { get; protected set; }
        public string Description { get; protected set; }

        public Character(Sentence sentence, string name, int age, string desciption)
        {
            Id = sentence.Id;
            Name = name;
            Age = age;
            Description = desciption;
        }
        protected Character()
        {

        }

        public void AddActor(User user)
        {
            _actors.Add(user);
        }
    }
}
