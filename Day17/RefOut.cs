using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RefOut
{
    internal class Program
    {
        static void DoThis(out int num)
        {
            num = 0;
        }

        static bool TrimFiveChars(ref string data)
        {
            if(data.Length > 5)
            {
                data = data.Substring(0, 5);
                return true;
            }
            return false;
        }

        static void Main()
        {
            int number;
            DoThis(out number);
            System.Console.WriteLine(number);

            string text = "Old Data";
            if(TrimFiveChars(ref text))
            {
                System.Console.WriteLine(text + "...");
            }
            else
            {
                System.Console.WriteLine(text);
            }
        }
    }
}