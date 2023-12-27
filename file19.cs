using System;
using System.IO;

class file19
{
    public static void Run()
    {
        // Замените "input.txt" на путь к вашему файлу с вещественными числами.
        string filePath = "input.txt";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                double[] numbers = new double[lines.Length];

                // Преобразуем строки в числа и сохраняем их в массив
                for (int i = 0; i < lines.Length; i++)
                {
                    if (double.TryParse(lines[i], out double number))
                    {
                        numbers[i] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка в чтении числа в строке {i + 1}.");
                        return;
                    }
                }

                // Находим последний локальный максимум, начиная с конца массива
                for (int i = numbers.Length - 2; i > 0; i--)
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine($"Последний локальный максимум: {numbers[i]}");
                        return;
                    }
                }

                Console.WriteLine("Локальный максимум не найден.");
            }
            else
            {
                Console.WriteLine("Файл пуст.");
            }
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}
