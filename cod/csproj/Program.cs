using System;
using Newtonsoft.Json;

namespace cod
{
    class Program
    {
        static void Main()
        {
            var person = new { Name = "Alex", Age = 25 };
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine($"JSON: {json}");
        }
    }
}
