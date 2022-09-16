using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace introduction_to_oop
{
    internal class Penguin : Bird
    {
        public Penguin(string name, string color) : base(name, color)
        { }

        public override void Speak()
        {
            Console.WriteLine($"Hi! I am  {Name} and I am a {Color} penguin");
        }
        public override void Fly()
        {
            Console.WriteLine($"Whoops I cann't fly.... Waddle Waddle!");
        }
    }
}
