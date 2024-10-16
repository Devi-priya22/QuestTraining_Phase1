//StudentSystem

using System;

namespace Students
{

    internal class Program
    {
        static void Main()
        {
            var sManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Add Subject and Marks");
                Console.WriteLine("6. Exit");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var student = GetStudentData();
                        sManager.Add(student);
                        break;
                    case "2":
                        Console.Write("Enter the Reg number to search: ");
                        var regNo = Console.ReadLine();
                        sManager.Search(regNo);
                        break;
                   case "3":
                        Console.Write("Enter the Reg number to update: ");
                        var regNumToUpdate = Console.ReadLine();
                        Console.Write("Enter the new name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter the new standard: ");
                        var standard = int.Parse(Console.ReadLine());

                        Console.Write("Enter Subject One: ");
                        var subjectOne = Console.ReadLine();
                        Console.Write("Enter Marks for Subject One: ");
                        var markOne = int.Parse(Console.ReadLine());

                        Console.Write("Enter Subject Two: ");
                        var subjectTwo = Console.ReadLine();
                        Console.Write("Enter Marks for Subject Two: ");
                        var markTwo = int.Parse(Console.ReadLine());

                        Console.Write("Enter Subject Three: ");
                        var subjectThree = Console.ReadLine();
                        Console.Write("Enter Marks for Subject Three: ");
                        var markThree = int.Parse(Console.ReadLine());

                        sManager.Update(regNumToUpdate, name, standard, subjectOne, markOne, subjectTwo, markTwo, subjectThree, markThree);
                        break;
                    case "4":
                        Console.Write("Enter the Reg number to delete: ");
                        var studentNumberToDelete = Console.ReadLine();
                        sManager.Delete(studentNumberToDelete);
                        break;
                    case "5":
                        Console.Write("Enter the Reg number to add subject: ");
                        var regNumber = Console.ReadLine();
                        Console.Write("Enter the subject name: ");
                        var subject = Console.ReadLine();
                        Console.Write("Enter the marks: ");
                        var marks = int.Parse(Console.ReadLine());
                        sManager.AddSubject(regNumber, subject, marks);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private static StudentData GetStudentData()
        {
            StudentData student = new StudentData();

            Console.Write("Enter the students name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter the Reg number: ");
            student.RegNo = Console.ReadLine();

            Console.Write("Enter the standard (1 - 10): ");
            student.Standard = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject One: ");
            student.SubjectOne = Console.ReadLine();

            Console.Write("Enter Marks for Subject One: ");
            student.MarkOne = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Two: ");
            student.SubjectTwo = Console.ReadLine();

            Console.Write("Enter Marks for Subject Two: ");
            student.MarkTwo = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Three: ");
            student.SubjectThree = Console.ReadLine();

            Console.Write("Enter Marks for Subject Three: ");
            student.MarkThree = int.Parse(Console.ReadLine());

            Console.Write("Enter Max Marks: ");
            student.MaxMarks = int.Parse(Console.ReadLine());


            return student;
        }
    }
}