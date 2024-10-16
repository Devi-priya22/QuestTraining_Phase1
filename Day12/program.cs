//StudentSystem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var stud = GetStudentData();
                        sManager.Add(stud);
                        break;
                    case "2":
                        Console.Write("Enter the register number to search: ");
                        var RegNumber = Console.ReadLine();
                        sManager.Search(RegNumber);
                        break;
                    case "3":
                        var StudentToUpdate = GetStudentData();
                        sManager.Update(StudentToUpdate.RegNumber,
                            StudentToUpdate.Name,
                            StudentToUpdate.Class);
                        break;
                    case "4":
                        Console.Write("Enter the register number to delete: ");
                        var RegNumberToDelete = Console.ReadLine();
                        sManager.Delete(RegNumberToDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private static Student GetStudentData()
        {
            Student stud = new Student();

            Console.Write("Enter the student name: ");
            stud.Name = Console.ReadLine();

            Console.Write("Enter the class: ");
            stud.Class = int.Parse(Console.ReadLine());

            Console.Write("Enter the register number: ");
            stud.RegNumber = Console.ReadLine();

            Console.WriteLine("Enter Subject1: ");
            stud.Sub1 = Console.ReadLine();

            Console.WriteLine("Enter Mark1: ");
            stud.Mark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum Mark: ");
            stud.MaxMark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject2: ");
            stud.Sub2 = Console.ReadLine();

            Console.WriteLine("Enter Mark2: ");
            stud.Mark2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum Mark: ");
            stud.MaxMark2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject3: ");
            stud.Sub3 = Console.ReadLine();

            Console.WriteLine("Enter Mark3: ");
            stud.Mark3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum Mark: ");
            stud.MaxMark3 = int.Parse(Console.ReadLine());

            return stud;

        }
    }
}