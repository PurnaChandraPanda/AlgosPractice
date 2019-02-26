using System;
using System.Collections.Generic;
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
            var option = Console.ReadLine();

            // lower bound example: 1, 2, 3, 5, 6, 7, 8, 9
            // higher bound example: 1, 2, 3, 4, 5, 7
            var inputArray = new int[] { 1, 2, 3, 4, 5, 7 };
            int result = 0;
            if (option.Equals("1a"))
            {
                result = Helper.Search.GetMissingNumberInSequence(inputArray, 0, inputArray.Length - 1);
                Console.WriteLine(result);
            }
            else if (option.Equals("1b"))
            {
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



            Console.ReadLine();
        }
    }
}
