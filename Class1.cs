using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace introduction_to_oop
{
    internal class Parrot: Bird
    {
        public Parrot(string name, string color) : base(name, color)
        { }
        public override void Speak()
        {
            Console.WriteLine($"I am {Name} a Funny Parrot.... ");
        }
    }
}
