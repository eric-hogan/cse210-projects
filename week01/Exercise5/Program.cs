using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Hello World");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string numInput = Console.ReadLine();
            int userNum = int.Parse(numInput);
            return userNum;
        }

        static int SquareNumber(int number)
        {
            int numSquared = number * number;
            return numSquared;
        }

        static void DisplayResult()
        {
            DisplayMessage();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int numberSquared = SquareNumber(number);
            Console.WriteLine($"{name}, the square of your number is {numberSquared}.");
        }

        DisplayResult();
    }
}