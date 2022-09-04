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

    public class Pigeon : Bird
    {
        public Pigeon(string name, string color) : base(name, color)
        {

        }
        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }
        public void EatPizza()
        {
            Console.WriteLine("Delicious Pizza");
        }

        public void Sleep()
        {
            Console.WriteLine("I'm a sleeping pigeon");
        }
    }

    public class Penguin : Bird
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

    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        { }
        public override void Speak()
        {
            Console.WriteLine($"I am {Name} a Funny Parrot.... ");
        }
    }

    public interface IDance
    {
        void Spin();
        void DoTheCaterpiller();
        void Jump();


    }
}