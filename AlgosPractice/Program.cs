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
            // lower bound example: 1, 2, 3, 5, 6, 7, 8, 9
            // higher bound example: 1, 2, 3, 4, 5, 7
            var inputArray = new int[] { 1, 2, 3, 5, 6, 7, 8, 9};
            var result = Helper.Search.GetMissingNumberInSequence(inputArray, 0, inputArray.Length - 1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
