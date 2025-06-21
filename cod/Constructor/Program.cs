using System;

namespace cod
{
    class Program
    {
        private class Person
        {
            private string _FirstName;
            private string _SecondName;
            private int _Age;

            public Person(string FirstName, string SecondName, int Age)
            {
                _FirstName = FirstName;
                _SecondName = SecondName;
                _Age = Age;
            }
            public Person() : this("John", "Doe", 0)
            {
                // _FirstName = "John";
                // _SecondName = "Doe";
                // _Age = 0;
            }

            public void WriteInfo()
            {
                System.Console.WriteLine($"{_FirstName} {_SecondName} Возраст:{_Age}");
            }



        }
        static void Main()
        {

            Person person = new Person("Denys", "Matiushenko", 18);

            person.WriteInfo();

            Person person0 = new Person();

            person0.WriteInfo();




        }
    }
}