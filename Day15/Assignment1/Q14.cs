using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<float> floats = new List<float> { 1.1F, 3.2F, 5.4F, 4.5F };
        float num = floats.Average();
        Console.WriteLine(num);
    }
}
