using System;
using System.Threading.Tasks;

namespace cod
{
    class Program
    {
        static async Task DownloadPageAsync(string url, string filePath)
        {
            using HttpClient client = new HttpClient();
            string html = await client.GetStringAsync(url);
            await File.WriteAllTextAsync(filePath, html);
        }
        static async Task Main()
        {
            HttpClient client = new HttpClient();

            List<string> urls = new List<string>
            {
                "https://example.com",
                "https://jsonplaceholder.typicode.com",
                "https://www.wikipedia.org"
            };

            string outputDir = "pages";

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            List<Task> downloadTasks = new List<Task>();

            for (int i = 0; i < urls.Count; i++)
            {
                string fileName = Path.Combine(outputDir, $"page{i + 1}.html");
                downloadTasks.Add(DownloadPageAsync(urls[i], fileName));
            }

            await Task.WhenAll(downloadTasks);

            System.Console.WriteLine("Всё закончено");
        }
    }
}