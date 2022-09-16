using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introduction_to_oop
{
    public abstract class Bird : IDance
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Speak();

        public virtual void Fly()
        {
            Console.WriteLine("Hi there! I can fly.");
        }

        public void Spin()
        {
            Console.WriteLine($"{Name} Spin!!!");
        }

        public void DoTheCaterpiller()
        {
            Console.WriteLine($"{Name} Do the Wiggly Woo!!!!");
        }
        public void Jump()
        {
            Console.WriteLine("Jump in the air!!!");
        }

    }

}