using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace cod
{
    class Program
    {
        static async Task Main()
        {
            using HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/users";

            HttpResponseMessage response = await client.GetAsync(url);

            string result = await response.Content.ReadAsStringAsync();

            System.Console.WriteLine(result);





        }
    }
}