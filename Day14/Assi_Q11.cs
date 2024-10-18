// Write a Predicate<int> that checks if a given integer is even.

using System;

class Program
{
    static void Main(string[] args)
    {
        Predicate<int> isEven = number => number % 2 == 0;
        int Number = 4;
        bool result = isEven(Number);
        Console.WriteLine($"{Number} is even: {result}");  
    }
}
