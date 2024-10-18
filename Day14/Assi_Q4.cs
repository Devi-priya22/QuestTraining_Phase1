// Write an interface ICalculator that has methods Add(int a, int b) and Subtract(int a, int b). 
//Implement this interface in a SimpleCalculator class.

using System;

namespace CalculatorApp
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }
    public class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new SimpleCalculator();
            int sum = c.Add(5, 3);
            int difference = c.Subtract(5, 3);
            Console.WriteLine($"Sum: {sum}");            
            Console.WriteLine($"Difference: {difference}");
        }
    }
}
