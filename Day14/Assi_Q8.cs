// Write a Func<string, int> delegate that takes a string as input and returns the length of the string

using System;

class Program
{
    static void Main(string[] args)
    {
        Func<string, int> getLength = str => str.Length;
        string text= "Hello";
        int length = getLength(text);
        Console.WriteLine($"The length of '{text}' is: {length}");  
    }
}
