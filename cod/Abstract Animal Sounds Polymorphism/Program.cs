using System;

namespace cod
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Гав!!!");
        }
    }
    public class Cow : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Му-уу!!!");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Мяу!!!");
        }
    }
    class Program
    {
        static void Main()
        {
            var dog = new Dog();
            var cow = new Cow();
            var cat = new Cat();

            Animal[] Animals = { dog, cat, cow };

            for (int i = 0; i < Animals.Length; i++)
            {
                Animals[i].MakeSound();
            }
        }
    }
}