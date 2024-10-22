using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> {4,3,5,7,1};
        var orders = numbers.OrderByDescending(x => x);
        foreach (int num in orders)
        {
            Console.WriteLine(num);
        }
    }
}
