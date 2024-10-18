// Create a base class Employee with a virtual method CalculateBonus().
// In the derived class Manager, override CalculateBonus() to provide a custom calculation.

using System;

namespace EmployeeBonus
{
    public class Employee
    {
        public virtual void CalculateBonus()
        {
            Console.WriteLine("Employee bonus is calculated.");
        }
    }

    public class Manager : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine("Manager bonus is calculated using a custom formula.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var e = new Employee();
            e.CalculateBonus();  
            var m = new Manager();
            m.CalculateBonus();  
        }
    }
}
