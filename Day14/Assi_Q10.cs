// Create an Action<int, int> delegate that takes two integers and prints their sum

using System;

class Program
{
    static void Sum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"Sum: {sum}");
    }
    static void Main(string[] args)
    {
        Action<int, int> printSum = Sum;
        printSum(5, 3);  
    }
}
