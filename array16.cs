using System;

class array16
{
    public static void Run()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int N = int.Parse(Console.ReadLine()); // Запрашиваем у пользователя количество элементов
        int[] A = new int[N]; // Создаем массив с заданным количеством элементов

        // Заполняем массив значениями, введенными пользователем
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Введите элемент A[{i}]: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N/2; i++)
        {
                Console.Write(A[i] + " ");
                Console.Write(A[N - 1 - i] + " ");
        }
        if (N % 2 != 0)
        {
            Console.Write(A[N/2] + " ");
        }
    }
}
