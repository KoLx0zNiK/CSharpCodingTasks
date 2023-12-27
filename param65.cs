using System;

class param65
{
    // Описание типа TPoint
    struct TPoint
    {
        public double X; // Координата X
        public double Y; // Координата Y
    }

// Функция для вычисления расстояния между двумя точками
    static double Leng(TPoint p1, TPoint p2)
    {
        double deltaX = p2.X - p1.X;
        double deltaY = p2.Y - p1.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

// Описание типа TTriangle
    struct TTriangle
    {
        public TPoint A; // Вершина A
        public TPoint B; // Вершина B
        public TPoint C; // Вершина C

        // Функция для вычисления периметра треугольника
        public double Perim()
        {
            double sideAB = Leng(A, B);
            double sideBC = Leng(B, C);
            double sideCA = Leng(C, A);
            return sideAB + sideBC + sideCA;
        }
    }
    public static void Run()
    {
        // Задаем координаты точек A, B, C, D
        TPoint pointA = new TPoint { X = 0, Y = 1 };
        TPoint pointB = new TPoint { X = 3, Y = 5 };
        TPoint pointC = new TPoint { X = 0, Y = 2 };
        TPoint pointD = new TPoint { X = 1, Y = 4 };

        // Создаем треугольники ABC и ABD
        TTriangle triangleABC = new TTriangle { A = pointA, B = pointB, C = pointC };
        TTriangle triangleABD = new TTriangle { A = pointA, B = pointB, C = pointD };
        TTriangle triangleACD = new TTriangle { A = pointA, B = pointC, C = pointD };

        // Вычисляем периметры треугольников
        double perimABC = triangleABC.Perim();
        double perimABD = triangleABD.Perim();
        double perimACD = triangleACD.Perim();

        Console.WriteLine($"Периметр треугольника ABC: {perimABC}");
        Console.WriteLine($"Периметр треугольника ABD: {perimABD}");
        Console.WriteLine($"Периметр треугольника AD: {perimACD}");
    }
}