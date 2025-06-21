using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace cod
{
    class Program
    {
        static async Task DownloadImageAsync(string url, string filePath)
        {
            using HttpClient client = new HttpClient();

            byte[] imageData = await client.GetByteArrayAsync(url);

            await File.WriteAllBytesAsync(filePath, imageData);
        }
        static async Task Main()
        {
            List<string> imageUrls = new List<string>
            {
                "https://via.placeholder.com/150",
                "https://via.placeholder.com/200",
                "https://via.placeholder.com/250"
            };

            string outputDir = "images";

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            List<Task> downloadTasks = new List<Task>();

            for (int i = 0; i < imageUrls.Count; i++)
            {
                string fileName = Path.Combine(outputDir, $"image{i + 1}.jpg");
                downloadTasks.Add(DownloadImageAsync(imageUrls[i], fileName));
            }

            await Task.WhenAll(downloadTasks);


            System.Console.WriteLine("Всё сделано");

        }
    }
}