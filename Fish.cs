using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppZoo
{
    internal class Fish : Animal, ISwimmable
    {
        public int MaxDepth { get; set; }

        public Fish(string name, int age, string species, int maxDepth) : base(name, age, species)
        {
            MaxDepth = maxDepth;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fish sound");
        }

        public void Dive(int meters)
        {
            if (meters <= MaxDepth)
            {
                Console.WriteLine($"{Name} is diving {meters} meters.");
            }
            else
            {
                Console.WriteLine($"{Name} cannot dive deeper than {MaxDepth} meters.");
            }
        }

        public void Surface(int meters)
        {
            Console.WriteLine($"{Name} is surfacing {meters} meters.");
        }
    }
}
