using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, From: {FromAccountId}, To: {ToAccountId}, Amount: {Amount}, Date: {DateTime}";
        }
    }
}