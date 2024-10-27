using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyCustomException : Exception
    {
        public string Message { get; set; }
        public MyCustomException(string message)
        {
            Message = message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter two numbers:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                if(j == 0)
                {
                    throw new DivideByZeroException("Second number should not be zero.");
                }
                Console.WriteLine(i + j);
                Console.WriteLine(i - j);
                Console.WriteLine(i * j);
                Console.WriteLine(i / j);
			}
			catch (Exception e)
			{

                Console.WriteLine(e.Message);
			}
        }
    }
}