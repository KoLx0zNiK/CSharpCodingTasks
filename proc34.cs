// See https://aka.ms/new-console-template for more information

using System;
class proc34
{
    static double Fact(int x)
    {
        if (x == 0) return 1;
        return x * Fact(x - 1);
    }
    public static void Run()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Введите целое положительное число #" + (i + 1) + ":");
            if (int.TryParse(Console.ReadLine(), out int inputNumber) && inputNumber >= 0)
            {
                numbers[i] = inputNumber;
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                i--;
            }
        }
        foreach (int num in numbers)
        {
            double factorial = Fact(num);
            Console.WriteLine("Факториал " + num + "=" + factorial);
        }

    }
}
