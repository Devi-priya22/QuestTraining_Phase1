// Define an Action<string> delegate that prints a string to the console. Use this delegate to call a method that prints a welcome message.

using System;

class Program
{
    static void Main(string[] args)
    {
        Action<string> printMessage = message => Console.WriteLine(message);
        string welcomeMessage = "Welcome";
        printMessage(welcomeMessage); 
    }
}
