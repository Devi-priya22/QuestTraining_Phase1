using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenstion
{
    internal static class StringExtension
    {
        public static string ToTitleCase(this string str)
        {
            if (str == null)
            {
                return null;
            }
            var words = str.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(word.First().ToString().ToUpper() + word.Substring(1) + " ");
            }
            return sb.ToString().Trim();

        }
    }
}