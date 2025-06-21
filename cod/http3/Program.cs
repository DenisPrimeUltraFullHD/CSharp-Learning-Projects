using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace cod
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class Program
    {
        static async Task Main()
        {
            using HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/users";

            HttpResponseMessage response = await client.GetAsync(url);

            string json = await response.Content.ReadAsStringAsync();

            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name}: {user.Email}");
            }
        }
    }
}
