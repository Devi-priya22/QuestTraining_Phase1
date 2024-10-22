using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string> { "apple", "banana", "orange" };
        var groupWords = words.GroupBy(x => x.Length);
        foreach (var group in groupWords)
        {
            Console.WriteLine($"Words length {group.Key}:");
            foreach (var word in group)
            {
                Console.WriteLine(word);
            }
        }
    }
}