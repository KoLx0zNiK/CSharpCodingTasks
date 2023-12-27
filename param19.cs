using System;

class param19
{
        static double Norm1(double[,] A, int M, int N)
    {
        double maxNorm = double.MinValue;

        for (int j = 0; j < N; j++)
        {
            double columnNorm = 0.0;
            for (int i = 0; i < M; i++)
            {
                columnNorm += Math.Abs(A[i, j]);
            }

            if (columnNorm > maxNorm)
            {
                maxNorm = columnNorm;
            }
        }

        return maxNorm;
    }

    public static void Run()
    {
        int M = 5;
        int N = 6;

        double[,] A = new double[M, N];

        Random random = new Random();

        Console.WriteLine("Исходная матрица A:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                A[i, j] = random.NextDouble();
                Console.Write($"{A[i, j],8:F2} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int K = 1; K <= M; K++)
        {
            double norm = Norm1(A, K, N);
            Console.WriteLine($"Norm1(A, {K}, {N}) = {norm,8:F2}");
        }
    }
}