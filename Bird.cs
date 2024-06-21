using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppZoo
{
    internal class Bird : Animal, IFlyable
    {
        public Bird(string name, int age, string species) : base(name, age, species) { }

        public override void MakeSound()
        {
            Console.WriteLine("Bird sound");
        }

        public void TakeOff()
        {
            Console.WriteLine($"{Name} is taking off.");
        }

        public void Land()
        {
            Console.WriteLine($"{Name} is landing.");
        }
    }
}
