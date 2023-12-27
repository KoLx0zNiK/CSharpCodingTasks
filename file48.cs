using System;
using System.IO;

class file48
{
    public static void Run()
    {
        string fileA = "SA.txt";
        string fileB = "SB.txt";
        string fileC = "SC.txt";
        string fileD = "SD.txt";

        try
        {
            using (StreamReader readerA = new StreamReader(fileA))
            using (StreamReader readerB = new StreamReader(fileB))
            using (StreamReader readerC = new StreamReader(fileC))
            using (StreamWriter writerD = new StreamWriter(fileD))
            {
                string lineA, lineB, lineC;

                while ((lineA = readerA.ReadLine()) != null && (lineB = readerB.ReadLine()) != null && (lineC = readerC.ReadLine()) != null)
                {
                    // Записываем элементы из файлов A, B и C в файл D чередующимися
                    writerD.WriteLine(lineA);
                    writerD.WriteLine(lineB);
                    writerD.WriteLine(lineC);
                }

                Console.WriteLine("Файл SD создан успешно.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
