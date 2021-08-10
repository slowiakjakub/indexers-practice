using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a person's name to search for in a team: ");
            string name = Console.ReadLine();

            Team team = new Team();
            Person person = team[name]; // making use of indexers

            Console.Clear();
            if (person != null)
            {
                Console.WriteLine($"Teammate name: {person.Name}\n" +
                $"Teammate age: {person.Age} ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Cannot find a person named: {name}");
            }

        }
    }
}
