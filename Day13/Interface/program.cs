using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class SchoolStudent : IStudent
    {
        public string Name { get; set; }

        public const string SchoolName = "School X";

        public void Display()
        {
            Console.WriteLine($"Student name: {Name}, College Name: {SchoolName}");
        }
    }

    class CollegeStudent : IStudent
    {
        public string Name { get; set; }

        public const string CollegeName = "Collagge X";

        public void Display()
        {
            Console.WriteLine($"Student name: {Name}, College Name: {CollegeName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<IStudent>
            {
                new SchoolStudent {Name = "John"},
                new SchoolStudent {Name = "Jane"},
                new CollegeStudent {Name = "Mark"},
                new CollegeStudent {Name="Mary"}
            };

            foreach (var student in students)
            {
                student.Display();
            }
        }
    }
}