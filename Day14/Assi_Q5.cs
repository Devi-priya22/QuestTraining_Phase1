 //Define a delegate Operation that takes two integers as parameters.
 //Write methods Add and Multiply that match this delegate signature. 
 //Demonstrate how to use the delegate to call these methods.

using System;

namespace DelegateCalculate
{
    public delegate int Operation(int a, int b);
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            var a = new Operation(c.Add);
            var m = new Operation(c.Multiply);
            int sum = a(5, 3);
            int product = m(5, 3);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
        }
    }
}
