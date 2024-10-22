using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 3, 50, 80, 2 };
        var countNumber = numbers.Where(x => x > 10).Count();
        Console.WriteLine(countNumber);
    }
}
