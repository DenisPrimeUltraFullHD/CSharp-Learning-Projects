using System;

namespace cod
{
    public class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void Speak()
        {
            System.Console.WriteLine("Some sound");
        }
    }
    public class Dog : Animal
    {
        public Dog() : base("Unknown") { }
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{name} says: Woof!");
        }


    }
    class Program
    {
        static void Main()
        {
            var d1 = new Dog();
            var d2 = new Dog("Rex");

            d1.Speak();
            d2.Speak();







        }
    }
}