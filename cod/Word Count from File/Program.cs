
using System;
using System.IO;

namespace cod
{
    class Program
    {
        static void Main()
        {
            using (FileStream stream1 = File.OpenRead("Info.txt"))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);

                string[] words = textFromFile.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("Количество слов " + words.Length);
            }
        }
    }
}