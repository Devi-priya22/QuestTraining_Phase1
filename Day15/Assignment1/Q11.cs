using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 60, 7, 8, 90, 10 };
        var greaterThan = numbers.Where(n => n > 50);
        foreach (int number in greaterThan)
        {
            Console.WriteLine(number);
        }
    }
}