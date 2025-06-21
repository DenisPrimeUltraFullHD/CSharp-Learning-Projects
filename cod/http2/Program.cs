using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace cod
{
    class Program
    {
        public class Post
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }
        static async Task Main()
        {
            using HttpClient client = new HttpClient();

            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpResponseMessage response = await client.GetAsync(url);

            string json = await response.Content.ReadAsStringAsync();

            List<Post> posts = JsonSerializer.Deserialize<List<Post>>(json);

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine($"Заголовок {i + 1}: {posts[i].Title}");
            }
        }
    }
}