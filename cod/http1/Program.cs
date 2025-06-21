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

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                System.Console.WriteLine("Успешный ответ от сервера!");
                System.Console.WriteLine(json.Substring(0, 300) + "...\n");
            }
            else
            {
                System.Console.WriteLine("Ошибка!!!");
            }







        }
    }
}