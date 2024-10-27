using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTable
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        const string connStr = @"Data Source=ASUS; Database=QuestDB;Integrated Security=True";
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book { BookID = 1, Title = "Book One", Author = "Author A", Price = 2001 },
                new Book { BookID = 2, Title = "Book Two", Author = "Author B", Price = 2002 },
                new Book { BookID = 3, Title = "Book Three", Author = "Author C", Price = 2003 },
                new Book { BookID = 4, Title = "Book Four", Author = "Author D", Price = 2004 },
                new Book { BookID = 5, Title = "Book Five", Author = "Author E", Price = 2005 }
            };

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                foreach (var book in books)
                {
                    var insertQuery = "INSERT INTO Books (Id, Name, Author, Price) VALUES (@Id, @Name, @Author, @Price)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@Id", book.BookID);
                        command.Parameters.AddWithValue("@Name", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@Price", book.Price);
                        command.ExecuteNonQuery();
                    }
                }
                conn.Close();

                var selectQuery = "SELECT Id, Name, Author, Price FROM Books";

                conn.Open();
                var command1 = new SqlCommand(selectQuery, conn);
                var reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var author = reader.GetString(2);
                    var price = reader.GetInt32(3);

                    Console.WriteLine($"{id} - {name} - {author} - {price}");
                }
                conn.Close();
            }
        }
    }
}