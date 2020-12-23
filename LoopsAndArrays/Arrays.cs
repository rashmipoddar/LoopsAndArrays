using System;
namespace LoopsAndArrays
{
    public class Arrays
    {
        public Arrays()
        {
        }

        public static void RunArrays()
        {
            int[] numbersArray = CreateAndFillArray();
            //Array.ForEach(numbersArray, Console.WriteLine);
            PrintArrayInReverse(numbersArray);
            SumOfArray(numbersArray); // 55
            PrintArrayElements(numbersArray);
            int[,] indicesProductArray = CreateTwoDimensionalArray();
            PrintTwoDimensionalArray(indicesProductArray);

        }


        public static int[] CreateAndFillArray()
        {
            int[] numbers = new int[10];
            int counter = 0;
            while (counter < 10)
            {
                numbers[counter] = counter + 1;
                counter += 1;
            }
            return numbers;
        }

        public static void PrintArrayInReverse(int[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void SumOfArray(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        public static void PrintArrayElements(int[] numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));            
        }

        public static int[,] CreateTwoDimensionalArray()
        {
            int[,] twoDArray = new int[3, 4];

            int dimensions = twoDArray.Rank;
            Console.WriteLine($"No. of dimensions: {dimensions}");

            int row = twoDArray.GetLength(0);
            Console.WriteLine($"Rows: {row}");

            int col = twoDArray.GetLength(1);
            Console.WriteLine($"Cols: {col}");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    twoDArray[i, j] = i * j; 
                }
            }
            return twoDArray;
        }

        public static void PrintTwoDimensionalArray(int[,] productArray)
        {
            for (int i = 0; i < productArray.GetLength(0); i++)
            {
                for (int j = 0; j < productArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Value at [{i}, {j}]: {productArray[i, j]}");
                }
            }
            
        }
    }
}