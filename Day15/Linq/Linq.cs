using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, -5, -8 };
            var r = data.Where(i => i < 0);
            var firstItem = data.First();
            var firstOrDefault = data.FirstOrDefault();

            var lst = data.Last();
            var lastOrDefult = data.LastOrDefault();

            var sortedAscending = data.OrderBy(i => i);
            var sortedDescending = data.OrderByDescending(i => i);

            var min = data.Min();
            var minGreaterThanFive = data.Min(x => x > 5);
            var max = data.Max();
            var maxGreaterThanFive = data.Max(x => x > 5);

            var count = data.Count(); // Return's the numer of elements in any collection type.
            var countOfNumbersLessThanFive = data.Count(x => x < 5);

            var distinctElements = data.Distinct();
            var firstFive = data.Take(5);
            // var lastFive = data.TakeLast(5); // Not available in .NET Framework
            var skipFirtFive = data.Skip(5);
            // var skipLastFive = data.SkipLast(5); // Not available in .NET Framework

            var takeWhile = data.TakeWhile(x => x > 5);
            var skipWhile = data.SkipWhile(x => x > 5);

            var where = data.Where(x => x < 5);
        }
    }
}