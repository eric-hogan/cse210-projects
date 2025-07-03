using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomeGenerator = new Random();
        int number = randomeGenerator.Next(1, 5);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNum = int.Parse(guess);

        int guessCount = 1;
        string playAgain = "yes";

        do
        {
            while (guessNum != number)
            {
                if (guessNum < number)
                {
                    Console.WriteLine("Higher");
                }

                else if (guessNum > number)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNum = int.Parse(guess);

                guessCount += 1;

            }

            Console.WriteLine($"Great Job. You guessed the magic number in {guessCount} guess(es)!");
        } while 
    }
}