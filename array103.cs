using System;

class array103
{
    public static void Run()
    {
        Console.Write("Введите размер массива: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int[] newArray = new int[N + 2];
        Random rnd = new Random();

        
        for (int i = 0; i < N; i++)
        {
            array[i] = rnd.Next(0,100);
            Console.WriteLine($"{ array[i]}");
        }

        int minValue = array[0];
        int maxValue = array[0];
        int minIndex = 0;
        int maxIndex = 0;

        
        for (int i = 1; i < N; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }
        Console.WriteLine($"минимальный индекс " + minIndex);
        Console.WriteLine($"минимальное значение " + minValue);
        Console.WriteLine($"максимальный индекс " + maxIndex);
        Console.WriteLine($"максимальное значение " + maxValue);


        int m = 0;
        for(int i = 0; i < N;i++)
        {
            if (i == minIndex)
            {              
                newArray[m] = 0;
                m++;
            }
            if (i == maxIndex)
            {
                newArray[m] = array[i];
                newArray[m + 1] = 0;
                m++;
            } 
            else 
            {
                newArray[m] = array[i];
            }
            m++;
        }
        for (int i = 0; i < N + 2; i++)
        {
            Console.WriteLine($"{newArray[i]} ");
        }
    }
}
