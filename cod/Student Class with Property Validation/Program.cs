using System;

namespace cod
{
    public class Student
    {
        private string name;
        private int score;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    this.name = "John";
                }
                else
                {
                    this.name = value;
                }

            }
        }
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if (value > 100 || value < 0)
                {
                    this.score = 0;
                }
                else
                    this.score = value;
            }
        }
    }
    public class Program
    {
        public static void Main()
        {

            Student Student = new Student();
            Console.Write("Введите имя: ");
            Student.Name = System.Console.ReadLine();
            Console.Write("Введите балл: ");
            Student.Score = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine($"Оценки {Student.Name} {Student.Score}");


        }
    }
}
