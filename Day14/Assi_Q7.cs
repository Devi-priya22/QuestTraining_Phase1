// Define a Func<int, int, int> delegate that takes two integers as parameters and returns their sum.

using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> add = (a, b) => a + b;
        int sum = add(5, 3);
        Console.WriteLine($"Sum: {sum}");  
    }
}
