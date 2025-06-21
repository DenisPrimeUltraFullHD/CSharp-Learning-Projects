using System;

namespace cod
{
    public class Vehicle
    {
        string Brand { get; set; }
        int Year { get; set; }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public virtual void PrintInfo()
        {
            System.Console.WriteLine($"Бренд: {Brand}, Год выпуска: {Year}");
        }

    }
    public class Car : Vehicle
    {
        int NumberOfDoors { get; set; }

        public Car(string brand, int year, int doors) : base(brand, year)
        {
            NumberOfDoors = doors;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            System.Console.Write($"Количество дверей: {NumberOfDoors}");
        }
    }
    class Program
    {
        static void Main()
        {

            var vehicle = new Vehicle("Хонда", 2006);
            var car = new Car("Митцубиши", 2010, 4);

            vehicle.PrintInfo();
            car.PrintInfo();
        }
    }
}