 //Create an abstract class Vehicle with a property Speed and an abstract method Drive(). 
 //Implement the Drive() method in two derived classes Car and Bicycle.

using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void Drive();
    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving a car at speed {Speed} km/h.");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Riding a bicycle at speed {Speed} km/h.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c= new Car { Speed = 60 };
            var b = new Bicycle { Speed = 20 };
            c.Drive();
            b.Drive();
        }
    }
}
