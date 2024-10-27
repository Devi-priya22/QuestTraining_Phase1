using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 3];
            Console.WriteLine(data.Length);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter value for {i}, {j} : ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.WriteLine($"{data[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}