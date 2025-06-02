using System;
using System.IO;

namespace cod
{
    class Program
    {
        static void Main()
        {  
            try
            
            {
            
                    using(FileStream stream1 = File.OpenRead("Info.txt"))
                    {
                        byte[] array = new byte[stream1.Length];
                        stream1.Read(array, 0, array.Length);

                        string textFromFile = System.Text.Encoding.Default.GetString(array);
                        
                    }

            }
            catch(FileNotFoundException)
            {
                System.Console.WriteLine("Такого файла не существует!!!");
            }
        }
    }
}  
