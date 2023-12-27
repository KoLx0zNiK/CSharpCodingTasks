using System;
using System.IO;

class file88
{
    public static void Run()
    {
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";

        if (File.Exists(inputFileName))
        {
            string[] lines = File.ReadAllLines(inputFileName);

            int rowCount = lines.Length;

            double[,] matrix = new double[rowCount, rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] elements = lines[i].Split(' ');
                for (int j = 0; j < rowCount; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = Convert.ToDouble(elements[j]);
                    }
                    else if (Math.Abs(i - j) == 1)
                    {
                        matrix[i, j] = Convert.ToDouble(elements[j]);
                    }
                    else
                    {
                        matrix[i, j] = 0.0;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < rowCount; j++)
                    {
                        writer.Write(matrix[i, j].ToString() + " ");
                    }
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Файл с элементами трехдиагональной матрицы создан успешно.");
        }
        else
        {
            Console.WriteLine("Исходный файл не найден.");
        }
    }
}
