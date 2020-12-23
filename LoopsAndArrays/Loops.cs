using System;
namespace LoopsAndArrays
{
    public class Loops
    {
        public Loops()
        {
        }

        public static void RunLoops()
        {
            // CreateInfiniteLoop();
            PrintOddDigitUsingWhile("0123456789"); // 13579
            Console.WriteLine();
            PrintOddDigitUsingDoWhile("0123456789"); // 13579
            Console.WriteLine();
            PrintOddDigitUsingFor("0123456789"); // 13579
            Console.WriteLine();
            PrintOddDigitUsingForEach("0123456789"); // 13579
            Console.WriteLine();
            PrintIndexOfDuplicateChar("abcade"); // 3
        }

        public static void CreateInfiniteLoop()
        {
            while (true)
                Console.WriteLine("This is an infinite loop");
        }

        public static void PrintOddDigitUsingWhile(string digits)
        {
            int length = digits.Length;
            int counter = 0;
            while (counter < length)
            {
                char currentChar = digits[counter];
                int currentNumber = Int32.Parse(currentChar.ToString());
                if (currentNumber % 2 != 0)
                {
                    Console.Write(currentChar);
                }
                counter += 1;
            }
        }

        public static void PrintOddDigitUsingDoWhile(string digits)
        {
            int length = digits.Length;
            int counter = 0;
            do
            {
                char currentChar = digits[counter];
                int currentNumber = Int32.Parse(currentChar.ToString());
                if (currentNumber % 2 != 0)
                {
                    Console.Write(currentChar);
                }
                counter += 1;
            }
            while (counter < length);
        }

        public static void PrintOddDigitUsingFor(string digits)
        {
            for (int i  = 0; i < digits.Length; i++)
            {
                char currentChar = digits[i];
                int currentNumber = Int32.Parse(currentChar.ToString());
                if (currentNumber % 2 != 0)
                {
                    Console.Write(currentChar);
                }
            }
            
        }

        public static void PrintOddDigitUsingForEach(string digits)
        {
            foreach (char digit in digits)
            {
                int currentNumber = Int32.Parse(digit.ToString());
                if (currentNumber % 2 != 0)
                {
                    Console.Write(digit);
                }
            }

        }

        public static void PrintIndexOfDuplicateChar(string duplicate)
        {
            char firstChar = duplicate[0];
            for (int i = 1; i < duplicate.Length; i++)
            {
                if (duplicate[i] == firstChar)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
