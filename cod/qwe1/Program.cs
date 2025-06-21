using System;
using System.Threading.Tasks;

namespace cod
{
    class Program
    {
        public static async Task DownloadSimulationAsync(CancellationToken token)
        {
            int time = 0;
            while (time < 10)
            {
                token.ThrowIfCancellationRequested();

                time++;
                System.Console.WriteLine($"Скачано {time * 10}%!");
                await Task.Delay(1000);
            }
            System.Console.WriteLine("Скачивание завершено!");
        }

        static async Task Main()
        {
            var cts = new CancellationTokenSource();

            var task = DownloadSimulationAsync(cts.Token);

            Console.ReadKey();
            cts.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                System.Console.WriteLine("Главный: загрузка была отменена!");
            }

        }
    }
}