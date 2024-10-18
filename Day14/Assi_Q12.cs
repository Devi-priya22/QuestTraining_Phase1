// Create a Predicate<string> that checks if a given string starts with the letter 'A

using System;

class Program
{
    static bool StartsWithA(string str)
    {
        return str.StartsWith("A");
    }
    static void Main(string[] args)
    {
        Predicate<string> startsWithA = StartsWithA;
        string text = "Aeroplane";
        bool result = startsWithA(text);
        Console.WriteLine($"'{text}' starts with 'A': {result}");  
    }
}
