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
            try
            {
                using HttpClient client = new HttpClient();
                byte[] imageData = await client.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(filePath, imageData);
                Console.WriteLine($"Успешно скачано");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Ошибка при скачивании {url}: {ex.Message}");
            }
        }
        static async Task Main()
        {
            List<string> imageUrls = new List<string>
            {
                "https://via.placeholder.com/150",
                "https://via.placeholder.com/200",
                "https://via.placeholder.com/250",
                "https://invalid.url/image.jpg" //bad url (example)
            };

            string outputDir = "images";

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);

            }

            List<Task> downloadTask = new List<Task>();

            for (int i = 0; i < imageUrls.Count; i++)
            {
                string fileName = Path.Combine(outputDir, $"image{i + 1}.jpg");
                downloadTask.Add(DownloadImageAsync(imageUrls[i], fileName));
            }

            await Task.WhenAll(downloadTask);

            System.Console.WriteLine("Робота окончена");

        }
    }
}