using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>
            {
                new Account { Id = 1, Name = "John", Balance = 500 },
                new Account { Id = 2, Name = "Alice", Balance = 800 },
                new Account { Id = 3, Name = "Dane", Balance = 1000 }
            };

            var transactions = new List<Transaction>
            {
                new Transaction { Id = 1, FromAccountId = 1, ToAccountId = 2, Amount = 200, DateTime = DateTime.Now },
                new Transaction { Id = 2, FromAccountId = 2, ToAccountId = 3, Amount = 450, DateTime = DateTime.Now },
                new Transaction { Id = 3, FromAccountId = 3, ToAccountId = 1, Amount = 650, DateTime = DateTime.Now }
            };


            var tr = from transaction in transactions
                     join fromAccount in accounts on transaction.FromAccountId equals fromAccount.Id
                     join toAccount in accounts on transaction.ToAccountId equals toAccount.Id
                     select new
                     {
                         TransactionId = transaction.Id,
                         FromAccountName = fromAccount.Name,
                         ToAccountName = toAccount.Name,
                         Amount = transaction.Amount,
                         Date = transaction.DateTime
                     };


            var transactionDetails = transactions
                .Join(
                    accounts,
                    t => t.FromAccountId,
                    a => a.Id,
                    (transaction, account) => new { Transaction = transaction, FromAccount = account }) 
                .Join(
                    accounts,
                    res => res.Transaction.ToAccountId,
                    a => a.Id,
                    (res, toAccount) => new
                    {
                        TransactionId = res.Transaction.Id,
                        FromAccountName = res.FromAccount.Name,
                        ToAccountName = toAccount.Name,
                        res.Transaction.Amount,
                        res.Transaction.DateTime
                    }
                );

            Console.WriteLine("Detailed Transactions:");
            foreach (var item in transactionDetails)
            {
                Console.WriteLine($"Transaction ID: {item.TransactionId}, From: {item.FromAccountName}, To: {item.ToAccountName}, Amount: {item.Amount}, Date: {item.DateTime}");
            }
        }
    }
}