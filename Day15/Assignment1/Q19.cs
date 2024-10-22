using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var skipTake = numbers.Skip(5).Take(3);
        foreach (int number in skipTake)
        {
            Console.WriteLine(number);
        }
    }
}
