using System;

namespace cod
{
    class Program
    {
        static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return s;
            return s[^1] + Reverse(s.Substring(0, s.Length - 1));
        }

        static void Main()
        {
            string s = "ZxcSss";
            string new_s = Reverse(s);
            System.Console.WriteLine($"{s} {new_s}");
        }
    }
}