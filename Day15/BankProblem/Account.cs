using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Balance: {Balance}";
        }
    }
}