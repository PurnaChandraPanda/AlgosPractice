using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class FibonacciFinder
    {
        int[,] F = { { 1, 1 }, { 1, 0 } };
        int[,] M = { { 1, 1 }, { 1, 0 } };

        /// <summary>
        /// Find nth term in Fibonacci sequence via matrix exponentiation - leads to time complexity: O(logn)
        /// ref: https://www.geeksforgeeks.org/matrix-exponentiation/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindNthTerm(int n)
        {
            return power(F, n - 1);
        }

        // Function to compute F raise to power n-1. 
        private int power(int[,] F, int n)
        {
            // Multiply it with initial values i.e. 
            // with F(0) = 1, F(1) = 1 
            if (n == 1)
                return F[0, 0] + F[0, 1];

            power(F, n / 2);

            multiply(F, F);

            if (n % 2 != 0)
                multiply(F, M);

            // Multiply it with initial values i.e.  
            // with F(0) = 1, F(1) = 1 
            return F[0, 0] + F[0, 1];
        }

        // A utility function to multiply two  
        // matrices a[][] and b[][]. Multiplication 
        // result is stored back in b[][] 
        private void multiply(int[,] a, int[,] b)
        {
            // Creating an auxiliary matrix to store  
            // elements of the multiplication matrix 
            int[,] mul = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                        mul[i, j] += a[i, k] * b[k, j];
                }
            }

            // storing the multiplication result  
            // in a[][] 
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    // Updating our matrix 
                    a[i, j] = mul[i, j];
                }
        }
    }
}
