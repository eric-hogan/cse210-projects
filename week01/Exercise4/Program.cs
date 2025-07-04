using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


        List<int> numbers = new List<int>();
        int userNum = 1;

        Console.WriteLine("Enter a list of numbers type 0 when finished.");
        int sumNum = 0;
        int largeNum = 0;
        int smallNum = 9999;

        do
        {
            Console.Write("Ener a number ");
            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            if (userNum != 0)
                numbers.Add(userNum);

        } while (userNum != 0);


        foreach (int number in numbers)
        {


            sumNum += number;

            if (number > largeNum)
            {
                largeNum = number;
            }

            if (number > 0)
            {
                if (number < smallNum)
                {
                    smallNum = number;
                }
            }

        }
        float avgNum = ((float)sumNum) / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sumNum}");
        Console.WriteLine($"The average is: {avgNum}");
        Console.WriteLine($"The largest number is: {largeNum}");
        Console.WriteLine($"The smallest positive number is {smallNum}");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}