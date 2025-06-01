using System;

namespace cod
{
    class Student
    {
        private string name;
        private int age;
        private double grade;

        public string Name { get { return name; } set { name = value; } }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    this.age = value;
                else
                    this.age = 0;
            }
        }
        public double Grade
        {
            get { return grade; }
            set { if ((value <= 100) && (value >= 0)) { this.grade = value; } else this.grade = 0; }
        }
        public void PrintInfo()
        {
            System.Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nОценки: {Grade}");
        }
    }
    class Program
    {
        static void Main()
        {
            var stud = new Student();

            stud.Name = "Alexandro";
            stud.Age = -21;
            stud.Grade = 188.2;
            stud.PrintInfo();
        }
    }
}