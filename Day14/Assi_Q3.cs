// Create an interface IAnimal with a method Speak().
// Implement the interface in two classes Dog and Cat, each providing their own implementation of Speak().

using System;

namespace Animals
{
    public interface IAnimal
    {
        void Speak();
    }
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Bow bow");
        }
    }
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var d= new Dog();
            var c = new Cat();
            d.Speak();
            c.Speak();
        }
    }
}
