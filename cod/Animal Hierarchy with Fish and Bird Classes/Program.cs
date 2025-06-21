using System;

namespace cod
{
    class Animal
    {
        string TypeOfAnimal { get; set; }
        string WhereLive { get; set; }

        public Animal(string type, string live)
        {
            TypeOfAnimal = type;
            WhereLive = live;
        }

        public virtual void PrintInfo()
        {
            System.Console.WriteLine($"Вид животного: {TypeOfAnimal}, Живёт в: {WhereLive}");
        }
    }
    class Fish : Animal
    {
        string Name { get; set; }
        public Fish(string type, string live, string name) : base(type, live)
        {
            Name = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.WriteLine($"Имя рыбы: {Name}");
        }
    }
    class Bird : Animal
    {
        string Name { get; set; }
        public Bird(string type, string live, string name) : base(type, live)
        {
            Name = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.WriteLine($"Имя птицы: {Name}");
        }
    }
    class Program
    {
        static void Main()
        {
            var bird = new Bird("Птичка", "Украина", "Дрозд");
            var fish = new Fish("Рыбка", "Америка", "Лосось");

            bird.PrintInfo();
            fish.PrintInfo();
        }
    }
}