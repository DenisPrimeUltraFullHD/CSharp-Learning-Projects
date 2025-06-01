using System;

namespace cod{
    class Program{
        static void Main(){

            string numbers = "10,20,30,40";

            string[] nums = numbers.Split(',');

            foreach (var numbers0 in nums){
                System.Console.WriteLine($"{numbers0}");
            }






        }
    }
}
