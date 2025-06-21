using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    private class Book
    {
        string Author;
        string Title;
        int Year = 0;
        public void PrintInfo()
        {
            System.Console.WriteLine($"Book Title: {Title}, Author: {Author} Year: {Year}");
        }

        public Book(string _title, string _author, int _year)
        {
            Title = _title;
            Author = _author;
            Year = _year;
        }

    }
    static void Main()
    {
        Book book = new Book("1984", "Morgan le fey", 1948);

        book.PrintInfo();
    }
}
