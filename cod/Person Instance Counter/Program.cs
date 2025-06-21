using System;
using System.IO;

namespace cod
{
    public class Persona
    {
        public string name;

        public int age;

        public static int Count;

        public Persona(string _name, int _age)
        {
            name = _name;

            age = _age;

            Count++;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Persona persona3 = new Persona("Makoto Yuki", 17);

            Persona persona5 = new Persona("Ren Amayamiya", 18);

            System.Console.WriteLine("Количество созданных персон " + Persona.Count);

            Console.WriteLine($"Имя: {persona3.name}, Возраст: {persona3.age}");
            Console.WriteLine($"Имя: {persona5.name}, Возраст: {persona5.age}");
        }
    }

}