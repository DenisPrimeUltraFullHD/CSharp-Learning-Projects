using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Box<T>
    {
        public T Value { get; set; }
        public void Show()
        {
            System.Console.WriteLine("Содержимое коробки " + Value);
        }
    }
    static void Main()
    {
        Box<int> intBox = new Box<int> { Value = 123 };
        intBox.Show();

        Box<string> strBox = new Box<string> { Value = "Hello" };
        strBox.Show();


    }
}
