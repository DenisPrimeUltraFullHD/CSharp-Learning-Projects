using System;

namespace cod
{
    class Program
    {
        static int[,] Transpose(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] result = new int[columns, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[j, i] = matrix[i, j];

            return result;
        }

        static void Main()
        {
            var rand = new Random();
            System.Console.WriteLine("Введите количество строк");
            int m = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Введите количество столбцов");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];

            System.Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                    System.Console.Write(matrix[i, j] + "\t");
                }
                System.Console.WriteLine();
            }

            int[,] newmatrix = Transpose(matrix);

            System.Console.WriteLine();

            for (int i = 0; i < newmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newmatrix.GetLength(1); j++)
                {
                    System.Console.Write(newmatrix[i, j] + "\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}