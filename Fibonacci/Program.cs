using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            //Console.WriteLine($"Fibonacci({n}) = {new FibonacciFinder().FindNthTerm(n)}");
            //Console.WriteLine($"Fibonacci({n}) = {new FibonacciCore().Fib(n)}");
            //Console.WriteLine($"Fibonacci({n}) = {new FibonacciCore().DPFib(n)}");
            Console.WriteLine($"Fibonacci({n}) = {new FibonacciCore().FastFib(n)}");
            Console.ReadLine();
        }
    }
}
