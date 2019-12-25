using System;

namespace PyramidDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pick a number (1 to 10): ");
            int numberPicked = Int32.Parse(Console.ReadLine());

            Console.WriteLine("which operation to follow?? ");
            Console.WriteLine("\t1. print rightangle triangle");
            Console.WriteLine("\t2. print symmetric triangle");
            Console.WriteLine("\t3. print pyramid");
            
            var option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintRightAngleTriangle(numberPicked);
                    break;
                case 2:
                    PrintSymmetricTriangle(numberPicked);
                    break;
                case 3:
                    PrintDiamondPattern(numberPicked);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        private static void PrintRightAngleTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        private static void PrintSymmetricTriangle(int n)
        {
            // number of indices (columns)
            int k = 2 * n - 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }

                k = k - 1;

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintDiamondPattern(int n)
        {
            // number of spaces in front of printed character
            int space = n - 1;

            // run loop (parent loop)  
            // till number of rows 
            for (int i = 0; i < n; i++)
            {
                // loop for initially space, 
                // before star printing 
                for (int j = 0; j < space; j++)
                    Console.Write(" ");

                // Print i+1 stars 
                for (int j = 0; j <= i; j++)
                    Console.Write("* ");

                Console.Write("\n");
                space--;
            }

            // Repeat again in 
            // reverse order 
            space = 0;

            // run loop (parent loop) 
            // till number of rows 
            for (int i = n - 1; i > 0; i--)
            {
                // loop for initially space,  
                // before star printing 
                for (int j = 0; j < space; j++)
                    Console.Write(" ");

                // Print i stars 
                for (int j = 0; j < i; j++)
                    Console.Write(" *");

                Console.Write("\n");
                space++;
            }
        }
    }
}
