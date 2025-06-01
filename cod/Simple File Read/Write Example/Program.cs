using System;
using System.IO;

namespace cod
{
    class Program
    {
        static void Main()
        {  
            string text = {"Hi from GreenLand my name Denis"}
            using(FileStream stream = new FileStream("Info.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(array, 0, array.Length);
            }

            using(FileStream stream1 = File.OpenRead("Info.txt"))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                System.Console.WriteLine(textFromFile);
            }



        }

    }

}   