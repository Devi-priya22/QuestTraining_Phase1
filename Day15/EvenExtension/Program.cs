using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            Console.WriteLine(number.IsEven());
            Console.WriteLine(number.IsOdd());
        }
    }
}