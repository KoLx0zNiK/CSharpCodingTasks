using System;
using System.IO;

class file39
{
    public static void Run()
    {
        // Замените "input.txt" на путь к вашему файлу с целыми числами.
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        if (File.Exists(inputFilePath))
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (int.TryParse(line, out int number))
                    {
                        if (number >= 5 && number <= 10)
                        {
                            writer.WriteLine(number);
                        }

                        writer.WriteLine(number);
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка в чтении числа: {line}");
                    }
                }
            }

            Console.WriteLine("Числа в диапазоне 5-10 были продублированы.");
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}
