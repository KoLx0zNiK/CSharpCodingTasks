using System;
class matrix70
{
    public static void Run()
    {
        Console.Write("Введите кол-во строк: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во столбцов: ");
        int N = int.Parse(Console.ReadLine());

        int[,] newmatrix = new int[M + 1, N];
        int[,] matrix = new int[M,N];
        Console.WriteLine("Old Matrix: ");
        for (int i = 0; i < M; i++) 
        {
            for (int j = 0; j < N; j++)
            {
                Random rnd = new Random();
                matrix[i, j] = rnd.Next(0, 100);
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
        int maxRow = 0;
        int maxColumn = 0;
        int maxValue = matrix[0, 0];

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxRow = i;
                    maxColumn = j;
                }
            }
        }


        for (int i = 0; i < maxRow; i++)
        {
            for (int j = 0; j < N; j++)
            {
                newmatrix[i, j] = matrix[i, j];
            }
        }

        for (int j = 0; j < N; j++)
        {
            newmatrix[maxRow, j] = matrix[maxRow, j];
        }

        for (int i = maxRow + 1; i < M + 1; i++)
        {
            for (int j = 0; j < N; j++)
            {
                newmatrix[i, j] = matrix[i - 1, j];
            }
        }

        Console.WriteLine("Матрица после дублирования строки:");

        for (int i = 0; i < M + 1; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"{newmatrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

}