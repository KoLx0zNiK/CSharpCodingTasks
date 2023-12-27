using System;

class array65
{
    public static void Run()
    {
        Console.Write("Введите кол-во элемментов массива: ");
        int A = int.Parse(Console.ReadLine());
        int[] massiv = new int[A];
        int[] Newmassiv = new int[A]; 
        for (int i = 0; i < A; i++ )
        {
            Console.Write($"Введите элемент massive[{i}]: ");
            massiv[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введите число K: ");
        int K = int.Parse(Console.ReadLine());

        if (K >= 1 && K <= A)
        {
            for ( int i = 0; i < A; i++)
            {
                Newmassiv[i] = massiv[i] + massiv[K-1];
                Console.WriteLine($"Новый элемент massive[{i}]: " + Newmassiv[i]);
            }
        }
        else
        {
            Console.Write("Число К не удовлетворяет условию");
        }
    }
}