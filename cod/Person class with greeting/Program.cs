using System;

namespace cod
{

    class Person
    {

        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public string Greet()
        {
            return $"Привет, {GetFullName()}!";
        }
    }
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите имя; ");
            string firstName = Console.ReadLine();
            System.Console.WriteLine("Введите фамилию; ");
            string lastName = Console.ReadLine();

            Person person = new Person(firstName, lastName);

            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.Greet());
        }
    }
}
