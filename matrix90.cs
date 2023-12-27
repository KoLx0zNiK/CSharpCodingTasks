using System;

class matrix90
{
    public static void Run()
    {
        Console.Write("Введите порядок квадратной матрицы (M): ");
        int M = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        int[,] matrix = new int[M, M];

        // Заполняем матрицу значениями, введенными пользователем
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = rnd.Next(0,100);
                Console.Write($"{matrix[i,j]}\t ");

            }
            Console.WriteLine();
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (i + j >= M)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        Console.WriteLine("Матрица после обнуления элементов:");

        // Выводим матрицу после обнуления
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
