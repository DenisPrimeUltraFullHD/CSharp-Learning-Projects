using System;
using System.Threading.Tasks;

namespace cod
{
    class Program
    {
        public static async Task FindPrimesAsync(int max, CancellationToken token)
        {


            for (int i = 2; i < Math.Sqrt(max); i++)
            {
                token.ThrowIfCancellationRequested();

                if (isPrime(i))
                {
                    System.Console.WriteLine($"Найдено простое число: {i}");
                    await Task.Delay(500);
                }
            }
            System.Console.WriteLine("Поиск завершён!");

            static bool isPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i < Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static async Task Main()
        {
            var cts = new CancellationTokenSource();
            var task = FindPrimesAsync(10000, cts.Token);

            Console.ReadKey();
            cts.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                System.Console.WriteLine("Произведена отмена вычисления");
            }

        }
    }
}