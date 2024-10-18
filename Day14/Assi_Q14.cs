 //Create an abstract class Person with an abstract method Work(). 
 //Implement Work() in derived classes Doctor and Engineer to describe their specific jobs.

using System;

namespace AbstractClass
{
    public abstract class Person
    {
        public abstract void Work();
    }
    public class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("I am doctor.");
        }
    }
    public class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("I am Engineer.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new Doctor();
            var e = new Engineer();
            d.Work();     
            e.Work();   
        }
    }
}
