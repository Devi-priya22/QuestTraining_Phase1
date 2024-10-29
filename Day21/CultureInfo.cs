using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CultureInfoExample
{
    internal class Program
    {
        //static void Action1()
        //{
        //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");
        //    Console.WriteLine($"Action1 : {DateTime.Now}");
        //}
        static void Main(string[] args)
        {
            //var ci = new CultureInfo("en-IN");
            //CultureInfo.DefaultThreadCurrentCulture = ci;
            //CultureInfo.DefaultThreadCurrentUICulture = ci;

            //Console.WriteLine($"Main : {DateTime.Now}");

            //var t = new Thread(Action1);
            //t.Start();

            //var ci = new CultureInfo("en-GB");
            //var price = 100;
            //var formattedPrice = price.ToString("C", ci);
            //Console.WriteLine(formattedPrice);

            //var ci = new CultureInfo("en-GB");
            //var price = 100.777865;
            //var formattedPrice = price.ToString("G4");
            //Console.WriteLine(formattedPrice);

            //var ci = new CultureInfo("en-GB");
            var price = 100.777865;
            var formattedPrice = price.ToString("N");
            Console.WriteLine(formattedPrice);


        }
    }
}