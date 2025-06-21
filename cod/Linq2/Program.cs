using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
    }
    static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book{Title = "Book A", Year = 2005},
            new Book{Title = "Book B", Year = 1997},
            new Book{Title = "Book C", Year = 2010}
        };

        var sortedBooks = books.OrderByDescending(b => b.Year).ToList();

        foreach (var book in sortedBooks)
        {
            System.Console.WriteLine($"{book.Title} ({book.Year})");
        }

    }
}
