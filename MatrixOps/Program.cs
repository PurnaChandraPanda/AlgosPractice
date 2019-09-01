using System;
using System.Diagnostics;

namespace MatrixOps
{
    class Program
    {
        static int m = 20;
        static int n = 8;
        static int[,] a = new int[m, n];
        static int[,] visited = new int[m, n];
        static int[,] dp = new int[m, n];

        static void Main(string[] args)
        {
            // initialize 2d matrix
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] += i * n + j + 1;
                }
            }

            // print the 2d matrix
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i,j]} \t");
                }
                Console.WriteLine();
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //var sumValue = matrixSum(0, 0);
            var sumValue = matrixDPSum(0, 0);
            stopwatch.Stop();
            Console.WriteLine($"max sum value - {sumValue} in {stopwatch.Elapsed.TotalMilliseconds}");

            Console.ReadLine();
        }

        // get the maximum sum with moving to right and down only - not other direction
        private static int matrixSum(int i, int j)
        {
            if (i == m - 1 && j == n - 1)
                return a[i, j];

            int ans = 0;

            if (i < m - 1 && j < n - 1)
                ans = a[i, j] + Math.Max(matrixSum(i, j + 1), matrixSum(i + 1, j));
            else if (i == m - 1)
                ans = a[i, j] + matrixSum(i, j + 1);
            else
                ans = a[i, j] + matrixSum(i + 1, j);

            return ans;
        }

        // dynamic programming: get the maximum sum with moving to right and down only - not other direction
        private static int matrixDPSum(int i, int j)
        {
            if (i == m - 1 && j == n - 1)
                return a[i, j];
            
            if (visited[i, j] == 1)
                return dp[i, j];
            visited[i, j] = 1;
            
            if (i < m - 1 && j < n - 1)
                dp[i, j] = a[i, j] + Math.Max(matrixDPSum(i, j + 1), matrixDPSum(i + 1, j));
            else if (i == m - 1)
                dp[i, j] = a[i, j] + matrixDPSum(i, j + 1);
            else
                dp[i, j] = a[i, j] + matrixDPSum(i + 1, j);

            return dp[i, j];
        }
    }
}
