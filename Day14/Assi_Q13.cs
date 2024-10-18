//Define an abstract class Appliance with an abstract method TurnOn(). 
//Create a derived class Fan that implements the TurnOn() method.

using System;

namespace ApplianceClass
{
    public abstract class Appliance
    {
        public abstract void TurnOn();
    }

    public class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("The fan is turn on.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fan();
            f.TurnOn(); 
        }
    }
}
