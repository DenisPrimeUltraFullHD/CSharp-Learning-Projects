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
/*
Задача 2: Чтение файла с обработкой отсутствия файла
Описание:
Напишите программу, которая пытается прочитать текст из файла (например, data.txt) и вывести его содержимое в консоль. Если файла не существует, используйте try-catch для перехвата исключения (FileNotFoundException) и выведите сообщение, что файл не найден.

Подсказки:

Для чтения файла можно использовать File.ReadAllText.

Обработайте исключение FileNotFoundException и, возможно, другие исключения, связанные с вводом-выводом.
*/