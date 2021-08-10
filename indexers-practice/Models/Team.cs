using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{
    public class Team
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();

        public Team() // Generate some dummy data
        {
            TeamMembers.Add(new Person("Josh", 22));
            TeamMembers.Add(new Person("Anne", 21));
            TeamMembers.Add(new Person("James", 19));
            TeamMembers.Add(new Person("Evelyn", 19));
            TeamMembers.Add(new Person("Harper", 24));
            TeamMembers.Add(new Person("Mason", 24));
            TeamMembers.Add(new Person("Ella", 26));
            TeamMembers.Add(new Person("Jackson", 17));
            TeamMembers.Add(new Person("Avery", 21));
            TeamMembers.Add(new Person("Scarlett", 22));
        }
        public Person this[string name]
        {
            get
            {
                return TeamMembers.Find(x => x.Name == name);
            }
        }

    }
}
