using System;

namespace cod
{
    interface IMovable
    {
        void Move();
        void Stop();
    }
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Я еду на бензине!!!");
        }
        public void Stop()
        {
            Console.WriteLine("Уже не еду");
        }
    }
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Я еду на кинетической энергии!!!");
        }
        public void Stop()
        {
            Console.WriteLine("Уже не еду");
        }
    }
    class Program
    {
        static void Main()
        {
            var car = new Car();
            var bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
            car.Stop();
            bicycle.Stop();
        }
    }
}