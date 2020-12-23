using System;
namespace LoopsAndArrays
{
    public class Conditionals
    {
        public Conditionals()
        {
        }

        public static void RunConditionals()
        {
            IsGreaterThan(50); // "The number is less than 100
            IsGreaterThan(100); // The number is equal to 100
            IsGreaterThan(150); // The number is greater than 100

            PrintStringInformation("Hello World!"); // The message length is either less than 5 and odd or the message length is greater than equal to 10 and even
            PrintStringInformation("Hello"); // 
            PrintStringInformation("Ace"); // The message length is either less than 5 and odd or the message length is greater than equal to 10 and even

            PrintStringInfo("Hello World!"); // The message length is either less than 5 and odd or the message length is greater than equal to 10 and even
            PrintStringInfo("Hello"); // 
            PrintStringInfo("Ace"); // The message length is either less than 5 and odd or the message length is greater than equal to 10 and even
        }

        public static void IsGreaterThan(int number)
        {
            if (number < 100)
            {
                Console.WriteLine("The number is less than 100");
            }
            else if (number == 100)
            {
                Console.WriteLine("The number is equal to 100");
            }
            else 
            {
                Console.WriteLine("The number is greater than 100");
            }
        }

        public static void PrintStringInformation(string message)
        {
            if ((message.Length < 5 && message.Length % 2 != 0) || (message.Length >= 10 && message.Length % 2 == 0))
            {
                Console.WriteLine("The message length is either less than 5 and odd or the message length is greater than equal to 10 and even");
            }
        }

        public static void PrintStringInfo(string message)
        {
            if (message.Length < 5 )
            {
                if (message.Length % 2 != 0)
                {
                    Console.WriteLine("The message length is either less than 5 and odd or the message length is greater than equal to 10 and even");
                }
            }
            if (message.Length >= 10)
            {
                if (message.Length % 2 == 0)
                {
                    Console.WriteLine("The message length is either less than 5 and odd or the message length is greater than equal to 10 and even");
                }
            }
        }
    }
}
