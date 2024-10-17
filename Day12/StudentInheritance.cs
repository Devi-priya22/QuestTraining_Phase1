using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheritance
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class SchoolStudent : Student
    {
        public string SchoolName { get; set; }

        public override string ToString() => $"Name : {Name}, Email: {Email}, School: {SchoolName}";
    }

    class CollegeStudent : SchoolStudent
    {
        public string CollegeName { get; set; }

        public override string ToString() => $"Name : {Name}, Email: {Email}, School: {SchoolName}, CollegeName: {CollegeName}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            var cs = new CollegeStudent
            {
                Name = "Abcd",
                Email = "Abcd@gmail.com",
                SchoolName = "Abcde School",
                CollegeName = " Abcdef College"
            };
            Console.WriteLine(cs);
        }
    }
}