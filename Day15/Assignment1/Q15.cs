using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        var distinctNumbers = numbers.Distinct();
        foreach (int number in distinctNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
