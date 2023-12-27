using System;

class array56
{
    public static void Run()
    {
        Console.Write("Введите размер массива A: ");
        int N = int.Parse(Console.ReadLine()); // Запрашиваем у пользователя размер массива A
        int[] A = new int[N]; // Создаем массив A с заданным размером
        int countB = 0;
        int[] B = new int[] { };

        // Заполняем массив A значениями, введенными пользователем
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Введите элемент A[{i}]: ");
            A[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Массив B: ");
        foreach (int element in A)
        {
            if (element % 3 == 0)
            {
                
                Array.Resize(ref B, B.Length+1);
                B[B.Length - 1] = element;

                Console.Write(element + " ");


            }
            
        }
        Console.WriteLine();
        Console.WriteLine("Кол-во чисел, кратных трем: " + B.Length);
    }
}
