using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppZoo
{
    internal class Amphibian : Animal
    {
        public Amphibian(string name, int age, string species) : base(name, age, species) { }

        public override void MakeSound()
        {
            Console.WriteLine("Amphibian sound");
        }
    }
}
