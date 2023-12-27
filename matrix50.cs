using System;

class matrix50
{
    public static void Run()
    {
        Console.Write("Введите количество строк (M): ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов (N): ");
        int N = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[,] matrix = new int[M, N];


        Console.WriteLine("Матрица перед преобразования:");

        // Заполняем матрицу значениями, введенными пользователем
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rnd.Next(0, 100);
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        // Преобразовываем матрицу, меняя местами минимальный и максимальный элемент в каждом столбце
        for (int j = 0; j < N; j++)
        {
            int minIndex = 0;
            int maxIndex = 0;
            int minValue = matrix[0, j];
            int maxValue = matrix[0, j];

            // Находим индексы минимального и максимального элементов в столбце
            for (int i = 1; i < M; i++)
            {
                if (matrix[i, j] < minValue)
                {
                    minValue = matrix[i, j];
                    minIndex = i;
                }
                else if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxIndex = i;
                }
            }

            // Меняем местами минимальный и максимальный элемент
            int temp = matrix[minIndex, j];
            matrix[minIndex, j] = matrix[maxIndex, j];
            matrix[maxIndex, j] = temp;
        }

        Console.WriteLine("Матрица после преобразования:");

        // Выводим матрицу после преобразования
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
