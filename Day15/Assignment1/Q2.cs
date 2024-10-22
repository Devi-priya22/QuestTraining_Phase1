using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string> {"Apple" ,"Orange", "Banana"};
        var stringStartsA = strings.Where(s => s.StartsWith("A"));
        foreach (string str in stringStartsA)
        {
            Console.WriteLine(str);
        }
    }
}