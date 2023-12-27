using System;

class array83
{
    public static void Run()
    {
        Console.WriteLine("Введите кол-во элементов в массиве: ");
        int N = int.Parse(Console.ReadLine());
        int[] massiv = new int[N];
        int[] Newmassiv = new int[N];
        Random rnd = new Random();

        for (int i = 0; i < N; i++)
        {
            massiv[i] = rnd.Next(-100, 100);
            Console.WriteLine($"Элемент massiv[{i}]: " + massiv[i]) ;
        }

        Console.WriteLine("Новый массив выглядит так: ");
        Newmassiv[0] = massiv[N-1];
        Console.WriteLine($"Элемент massiv[0]: " + Newmassiv[0]);
        for (int i = 1; i < N; i++)
        {
            Newmassiv[i] = massiv[i - 1];
            Console.WriteLine($"Элемент massiv[{i}]: " + Newmassiv[i]);
        }
    }
}