using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Fibonacci
{
    class FibonacciCore
    {
        /// <summary>
        /// Find nth number in fibonacci sequence
        /// time complexity: O(2^n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            if (n <= 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        /// <summary>
        /// dynamic programming in Fibonacci number calculation
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DPFib(int n)
        {
            int[] F = new int[n + 1];

            F[0] = 1;
            F[1] = 1;

            for (int i = 2; i <= n; i++)
                F[i] = F[i - 1] + F[i - 2];

            return F[n];
        }

        /// <summary>
        /// find the fib number via formula
        /// time complexity: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FastFib(int n)
        {
            double basen = (1 + Math.Sqrt(5)) / 2;
            var result = Math.Round(Math.Pow(basen, n + 1) / Math.Sqrt(5));
            return Convert.ToInt32(result);
        }
    }
}
