using System;
using System.Threading;
using System.Threading.Tasks;

namespace cod
{
    class Program
    {
        static async Task Main()
        {
            using CancellationTokenSource cts = new CancellationTokenSource();

            Task task = SimulateDownloadAsync(cts.Token);

            System.Console.WriteLine("Нажмите Enter чтобы отменить загрузку.");

            Console.ReadLine();
            cts.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                System.Console.WriteLine("Загрузка отменена.");
            }
            System.Console.WriteLine("Программа завершена");



        }
        static async Task SimulateDownloadAsync(CancellationToken token)
        {
            for (int i = 0; i <= 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Загрузка {i * 10}%");
                await Task.Delay(500);

            }
            System.Console.WriteLine("Загрузка завершена.");
        }
    }
}