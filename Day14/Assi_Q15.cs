// Write a class Animal with a virtual method MakeSound(). 
//Create a derived class Dog that overrides MakeSound() to print "Bark!".

using System;

namespace AnimalSound
{

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.MakeSound(); 
        }
    }
}
