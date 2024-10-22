using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 3, 5, 4, 6, 2 };
        int num = numbers.Sum();
        Console.WriteLine(num);
    }
}
