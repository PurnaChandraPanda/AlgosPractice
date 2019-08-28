using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following functionalities: ");
            Console.WriteLine("\t1a. Get missing in sequence");
            Console.WriteLine("\t1b. Get missing in sequence with recursion");
            Console.WriteLine("\t2. Sort stack");
            Console.WriteLine("\t3a. BubbleSort");
            Console.WriteLine("\t3b. SelectionSort");
            Console.WriteLine("\t3c. InsertionSort");
            Console.WriteLine("\t3d. QuickSort");

            var option = Console.ReadLine();
            
            int result = 0;
            if (option.Equals("1a"))
            {
                // lower bound example: 1, 2, 3, 5, 6, 7, 8, 9
                // higher bound example: 1, 2, 3, 4, 5, 7
                var inputArray = new int[] { 1, 2, 3, 4, 5, 7 };

                result = Helper.Search.GetMissingNumberInSequence(inputArray, 0, inputArray.Length - 1);
                Console.WriteLine(result);
            }
            else if (option.Equals("1b"))
            {
                // lower bound example: 1, 2, 3, 5, 6, 7, 8, 9
                // higher bound example: 1, 2, 3, 4, 5, 7
                var inputArray = new int[] { 1, 2, 3, 4, 5, 7 };

                result = Helper.Search.GetMissingNumberInSequenceWithRecusion(inputArray, 0, inputArray.Length - 1);
                Console.WriteLine(result);
            }
            else if (option.Equals("2"))
            {
                var inputStack = new Stack<int>();
                inputStack.Push(2);
                inputStack.Push(3);
                inputStack.Push(7);
                inputStack.Push(5);
                inputStack.Push(1);
                var outputStack = Helper.Stacks.Sort(inputStack);
                foreach (var item in outputStack)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(Environment.NewLine);
            }
            else if (option.Equals("3a"))
            {
                var inputArray = new int[10] { 5, 6, 3, 1, 2, 8, 4, 21, 9, 12 };

                var watch = Stopwatch.StartNew();
                var outputArray = Helper.Sort.BubbleSort(inputArray);
                watch.Stop();

                Array.ForEach(
                    outputArray,
                    element => Console.Write($"{element} ")
                    );

                Console.WriteLine($"*****took {watch.ElapsedTicks} ticks*****");
            }
            else if (option.Equals("3b"))
            {
                var inputArray = new int[10] { 5, 6, 3, 1, 2, 8, 4, 21, 9, 12 };

                var watch = Stopwatch.StartNew();
                var outputArray = Helper.Sort.SelectionSort(inputArray);
                watch.Stop();

                Array.ForEach(
                    outputArray,
                    element => Console.Write($"{element} ")
                    );

                Console.WriteLine($"*****took {watch.ElapsedTicks} ticks*****");
            }
            else if (option.Equals("3c"))
            {
                var inputArray = new int[10] { 5, 6, 3, 1, 2, 8, 4, 21, 9, 12 };

                var watch = Stopwatch.StartNew();
                var outputArray = Helper.Sort.InsertionSort(inputArray);
                watch.Stop();

                Array.ForEach(
                    outputArray,
                    element => Console.Write($"{element} ")
                    );

                Console.WriteLine($"*****took {watch.ElapsedTicks} ticks*****");
            }
            else if (option.Equals("3d"))
            {
                var inputArray = new int[] { 10, 80, 30, 90, 40, 50, 70 };
                var outputArray = Helper.Sort.QuickSort(inputArray, 0, inputArray.Length - 1);

                Array.ForEach(
                    outputArray,
                    element => Console.Write($"{element} ")
                    );
            }
            
            Console.ReadLine();
        }
    }
}
