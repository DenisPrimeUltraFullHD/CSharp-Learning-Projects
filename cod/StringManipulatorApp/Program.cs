using System;

namespace cod
{
    class StringManipulator
    {

        static public string ReverseString(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            System.Console.WriteLine(reverse);
            return reverse;
        }
        static public int CountVowels(string text)
        {
            int result = 0;
            foreach (char a in text)
                if ("аеиоуюяaeiouy".Contains(a))
                {
                    result++;
                }
            System.Console.WriteLine(result);
            return result;
        }
        static public string ToUpperCase(string text)
        {
            string up_text = text.ToUpper();
            System.Console.WriteLine(up_text);
            return up_text;
        }
    }
    class Program
    {

        static void Main()
        {
            System.Console.WriteLine("Какую задачу хотите выполнить? (RS, CV, ToUp)");
            string operation = System.Console.ReadLine();

            System.Console.WriteLine("Ведите текст: ");
            string a = Console.ReadLine();

            switch (operation)
            {
                case "RS":
                    StringManipulator.ReverseString(a);
                    break;

                case "CV":
                    StringManipulator.CountVowels(a);
                    break;

                case "ToUp":
                    StringManipulator.ToUpperCase(a);
                    break;
            }
        }
    }
}
