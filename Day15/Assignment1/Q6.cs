using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string> { "Apple", "Orange", "anana" };
        string startsB = strings.FirstOrDefault(s => s.StartsWith("B"));
        Console.WriteLine(startsB);
        if (startsB == null)
        {
            Console.WriteLine("NULL");
        }
    }
}