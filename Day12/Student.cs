using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Task1
{
    class Student
    {
        public string Name;
        public string RegNumber;
        public int Class;
        public decimal Mark1;
        public decimal Mark2;
        public decimal Mark3;
        public string Sub1;
        public string Sub2;
        public string Sub3;
        public decimal MaxMark1;
        public decimal MaxMark2;
        public decimal MaxMark3;
        public override string ToString()
        {
            return $"StudentName: {Name}, RegisterNumber: {RegNumber}, Class: {Class}, Subject1: {Sub1}, Mark1: {Mark1}, Subject2: {Sub2}, Mark2: {Mark2}, Subject3: {Sub3} ";
        }
    }
}