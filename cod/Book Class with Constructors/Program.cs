using System;

namespace cod
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public Book()
        {
            Title = "No Title";
            Author = "No Author";
            Year = 0;
        }

        public Book(string title, string author) : this(title, author, 0)
        {
        }
        public Book(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public override string ToString()
        {
            return $"{Title} — {Author} ({Year})";
        }

    }
    class Program
    {
        static void Main()
        {
            var b1 = new Book();
            var b2 = new Book("Война и мир", "Лев Толстой");
            var b3 = new Book("1984", "Джордж Оруэлл", 1949);


            System.Console.WriteLine(b1);
            System.Console.WriteLine(b2);
            System.Console.WriteLine(b3);
        }
    }
}