using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgosPractice.Helper
{
    class Sort
    {
        public static int[] BubbleSort(int[] inputArray)
        {
            bool swapped = false;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = 0; j < inputArray.Length - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        // swap variables
                        inputArray[j] = inputArray[j] ^ inputArray[j + 1];
                        inputArray[j + 1] = inputArray[j] ^ inputArray[j + 1];
                        inputArray[j] = inputArray[j] ^ inputArray[j + 1];

                        swapped = true;
                    }
                }

                // break if there is no swap in innerloop
                if (!swapped)
                    break;
            }
            return inputArray;
        }

        public static int[] SelectionSort(int[] inputArray)
        {
            int minIndex;
            int temp;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[minIndex])
                        minIndex = j;
                }

                // swap minIndex element with original
                temp = inputArray[minIndex];
                inputArray[minIndex] = inputArray[i];
                inputArray[i] = temp;
            }

            return inputArray;
        }

        public static int[] InsertionSort(int[] array)
        {
            int j, key;

            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while ((j >= 0) && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            return array;
        }

        public static int[] QuickSort(int[] array, int left, int right)
        {
            int pivot = 0;

            if (left < right)
            {
                pivot = partition(array, left, right);
                Console.WriteLine($"pivot - {pivot}");
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }

            return array;
        }

        private static int partition(int[] array, int left, int right)
        {
            int p = array[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (array[j] <= p)
                {
                    i++;

                    // swap i and j elements
                    int temp1 = array[i];
                    array[i] = array[j];
                    array[j] = temp1;
                }
            }

            // swap i+1 and right elements
            int temp2 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp2;

            // return pivot element index
            return (i + 1);
        }
    }
}
