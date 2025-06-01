using System;

namespace cod{
    class Program{
        static void Main(){
            string a = "25";
            string b = "5";

            int a0 = int.Parse(a);
            int b0 = int.Parse(b);

            int result = a0 / b0;
            Console.WriteLine(result);
        }
    }
}