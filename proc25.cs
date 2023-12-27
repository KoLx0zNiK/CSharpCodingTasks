// See https://aka.ms/new-console-template for more information

using System;

class proc25
{
    static bool IsSquare(int K)
    {
        if (K <= 0) return false;
        int sqrtK = (int)Math.Sqrt(K);
        return sqrtK * sqrtK == K;
    }

    public static void Run()
    {

        int[] numbers = new int[10];
        for (int i=0; i<10; i++)
        {
            Console.WriteLine("Введите целое положительное число #" + (i+1) + ":");
            if (int.TryParse(Console.ReadLine(), out int inputNumber) && inputNumber > 0)
            {
                numbers[i] = inputNumber;
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                i--;
            }
        }

        int countOfSquares = 0;
        foreach (int num in numbers)
        {
            if (IsSquare(num)) countOfSquares++;
        }
        Console.WriteLine("Количество квадратов в наборе: " + countOfSquares);
    }
}
