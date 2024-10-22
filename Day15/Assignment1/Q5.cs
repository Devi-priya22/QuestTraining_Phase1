using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> {4,3,5,8,2};
        var squaresEven = numbers.Where(x => x % 2 ==0).Select(x => x * x);
        foreach (int num in squaresEven)
        {
            Console.WriteLine(num);
        }
    }
}
