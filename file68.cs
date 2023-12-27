using System;
using System.IO;

class file68
{
    public static void Run()
    {
        string dataFile = "data.txt"; 
        string fileWithMonth = "months.txt";
        string fileWithYear = "years.txt";

        if (File.Exists(dataFile))
        {
            string[] lines = File.ReadAllLines(dataFile);
            int[] monthArray = new int[lines.Length];
            int[] yearArray = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                if (DateTime.TryParse(lines[i], out DateTime date))
                {
                    monthArray[i] = date.Month;
                    yearArray[i] = date.Year;
                }
                else
                {
                    Console.WriteLine($"Ошибка в строке {i + 1}: {lines[i]} не является допустимой датой.");
                }
            }

            File.WriteAllLines(fileWithMonth, Array.ConvertAll(monthArray, month => month.ToString()));

            Array.Reverse(yearArray);
            File.WriteAllLines(fileWithYear, Array.ConvertAll(yearArray, year => year.ToString()));

            Console.WriteLine("Файлы с месяцами и годами созданы успешно.");
        }
        else
        {
            Console.WriteLine("Исходный файл не найден.");
        }
    }
}
