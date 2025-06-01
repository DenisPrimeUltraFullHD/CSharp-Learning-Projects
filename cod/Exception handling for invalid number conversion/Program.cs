using System;

namespace cod{
    class Program{
        static void Main(){

            string input = "abc";

            try{
                Convert.ToInt32(input);
            }
            catch(Exception){
                System.Console.WriteLine("Это не число");
            }





        }
    }
}