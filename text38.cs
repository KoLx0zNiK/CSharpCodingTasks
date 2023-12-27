using System;
using System.IO;

class text38
{
    public static void Run()
    {
        int K = 30; // Замените на нужное значение K
        string inputFileName = "input.txt"; // Замените на имя вашего файла
        string outputFileName = "output.txt";

        if (File.Exists(inputFileName))
        {
            using (StreamReader reader = new StreamReader(inputFileName))
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                string line;
                int currentLineLength = 0;
                bool newParagraph = true;

                while ((line = reader.ReadLine()) != null)
                {
                    line = line.TrimEnd(); // Удаляем пробелы в конце строки

                    if (line == "")
                    {
                        if (!newParagraph)
                        {
                            // Завершаем абзац пустой строкой
                            writer.WriteLine();
                            currentLineLength = 0;
                        }
                        newParagraph = true;
                    }
                    else
                    {
                        if (!newParagraph)
                        {
                            // Добавляем пробел между строками абзаца
                            writer.Write(" ");
                            currentLineLength++;
                        }

                        if (currentLineLength + line.Length <= K)
                        {
                            // Если текущая строка помещается в пределах K позиций
                            writer.WriteLine(line);
                            currentLineLength = 0;
                        }
                        else
                        {
                            // Если текущая строка не помещается, разбиваем её на несколько строк
                            int startIndex = 0;
                            while (startIndex < line.Length)
                            {
                                int endIndex = startIndex + Math.Min(K - currentLineLength, line.Length - startIndex);
                                writer.WriteLine(line.Substring(startIndex, endIndex - startIndex));
                                currentLineLength = 0;
                                startIndex = endIndex;
                            }
                        }

                        newParagraph = false;
                    }
                }
            }

            Console.WriteLine("Отформатированный текст сохранен в файле.");
        }
        else
        {
            Console.WriteLine("Исходный файл не найден.");
        }
    }
}
