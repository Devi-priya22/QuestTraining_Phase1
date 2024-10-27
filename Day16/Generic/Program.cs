using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic
{
    public class Person
    {
        public string Name { get; set; }
        public TEmailType Emails { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person<string[]>() {Name = "John"};
            var p2 = new Person<List<string>() {Name = "Jane"};
            var p3 = new Person<string>() {Name = "Jim"};

            p1.Emails = new string[] {"a@a.com", "a@b.com"};
            p2.Emails = new List<string {"1@mail.com", "2@mail.com"};
            p3.Emails = "3@mail.com";
        }
    }
}