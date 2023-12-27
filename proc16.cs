// See https://aka.ms/new-console-template for more information

using System;
class proc16
{
    static int Sign(double x)
    {
        if (x < 0) return -1;
        if (x > 1) return 1;
        else return 0;
    }
    public static void Run()
    {
        double A;
        double B;

        Console.WriteLine("Введите число А");
        A = Convert.ToDouble(Console.ReadLine());
        int signA = Sign(A);

        Console.WriteLine("Введите число B");
        B = Convert.ToDouble(Console.ReadLine());
        int signB = Sign(B);


        int result = signA + signB;

        Console.WriteLine("SignA = " + signA);
        Console.WriteLine("SignB = " + signB);
        Console.WriteLine("SignA + Sign B = " + result);
    }
}
