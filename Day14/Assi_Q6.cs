//Create a delegate PrintMessage that takes a string as a parameter. 
//Write a method DisplayMessage that prints the string passed to it.
//Use the delegate to call DisplayMessage.

using System;

namespace DelegateDisplay
{
    public delegate void PrintMessage(string message);
    class Program
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            var p = new PrintMessage(DisplayMessage);
            p("Hello");
        }
    }
}
