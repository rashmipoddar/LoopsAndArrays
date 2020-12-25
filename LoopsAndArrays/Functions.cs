using System;
namespace LoopsAndArrays
{
    public class Functions
    {
        public Functions()
        {
        }

        public static void RunFunctions()
        {
            Console.WriteLine(ConcatenateStrings("Hello", "Sara", ", "));
            int[] updatedNumbers = UpdateArrayElement(new int[] { 1, 2, 3 }, 0, 5);
            Array.ForEach(updatedNumbers, Console.WriteLine);
            int[] unchangedNumbers = UpdateArrayElement(new int[] { 1, 2, 3 }, 5, 5);
            Array.ForEach(unchangedNumbers, Console.WriteLine);
            Console.WriteLine(alternateWords("to be or not to be")); // to or to
            string greeting = "Hello World";
            Console.WriteLine(GetSubString(greeting)); // Hello World
            Console.WriteLine(GetSubString(greeting, 3)); // lo World
            Console.WriteLine(GetSubString(greeting, 6, 10)); // 
            Console.WriteLine(GetSubString(greeting, 11)); // 
            Console.WriteLine(ReturnSubstring(greeting)); // Hello World
            Console.WriteLine(ReturnSubstring(greeting, 3)); // lo World
            Console.WriteLine(ReturnSubstring(greeting, 6, 10)); // 
            Console.WriteLine(ReturnSubstring(greeting, 11)); //
            Console.WriteLine(AreArraysEqual(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })); // true
            Console.WriteLine(AreArraysEqual(new int[] { 1, 2 }, new int[] { 1, 2, 3 })); // false
            Console.WriteLine(AreArraysEqual(new int[] { 1, 2, 3 }, new int[] { 1, 3, 3 })); // false
            int number1 = 10;
            int number2 = 5;
            int sum;
            int difference;
            int product;
            int quotient;
            MathOperations(number1, number2, out sum, out difference, out product, out quotient);
            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            int indexForChar = 4;
            Console.WriteLine(GetChar(greeting, ref indexForChar)); // o
            indexForChar = 20;
            Console.WriteLine(GetChar(greeting, ref indexForChar)); // d
            Console.WriteLine(indexForChar); // 10
        }

        public static string ConcatenateStrings(string greeting, string name, string space)
        {
            string joined = greeting + space + name;
            return joined;
        }

        public static int[] UpdateArrayElement(int[] numbers, int index, int value)
        {
            if (index < numbers.Length)
            {
                numbers[index] = value;
            }
            return numbers;
        }

        public static string alternateWords(string sentence)
        {
            string newSentence = "";
            string[] words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i += 2)
            {
                if (i == 0)
                {
                    newSentence = words[i];
                }
                else
                {
                    newSentence = newSentence + " " + words[i];
                }
            }
            return newSentence;
        }


        // Set the default parameters to null for practice. According to the question it should be 0
        public static string GetSubString(string greeting, int? index = null, int? length = null)
        {
            int newIndex = index ?? 0;
            int newLength = length ?? (greeting.Length - newIndex);

            if (newIndex >= greeting.Length || (newIndex + newLength) > greeting.Length)
            {
                return "";
            }

            return greeting.Substring(newIndex, newLength);
        }

        public static string ReturnSubstring(string greeting, int index = 0, int length = 0)
        {
            if (length == 0)
            {
                length = greeting.Length - index;
            }

            if (index >= greeting.Length || (index + length) > greeting.Length)
            {
                return "";
            }

            return greeting.Substring(index, length);
        }

        public static bool AreArraysEqual(int[] numbers1, int[] numbers2)
        {
            if (numbers1.Length != numbers2.Length)
            {
                return false;
            }
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void MathOperations(int number1, int number2, out int sum, out int difference, out int product, out int quotient)
        {
            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;
        }

        // Using reference parameter
        public static char GetChar(string greeting, ref int index)
        {
            if (index < 0)
            {
                index = 0;
                return greeting[index];
            }

            if (index > greeting.Length)
            {
                index = greeting.Length - 1;
                return greeting[index];
            }
            return greeting[index];
        }
    }
}
