using System;

class array26
{
    public static void Run()
    {
        Console.Write("Введите размер массива A: ");
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];

        
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Введите элемент A[{i}]: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Числа из массива A, которые не являются локальными минимумами или максимумами:");

        for (int i = 1; i < N - 1; i++)
        {
            if (!IsLocalMinimum(A, i) && !IsLocalMaximum(A, i))
            {
                Console.WriteLine(A[i]);
            }
        }
    }

    
    static bool IsLocalMinimum(int[] array, int index)
    {
        return array[index] < array[index - 1] && array[index] < array[index + 1];
    }

    
    static bool IsLocalMaximum(int[] array, int index)
    {
        return array[index] > array[index - 1] && array[index] > array[index + 1];
    }
}
