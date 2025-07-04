using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";

        do
        {

            Random randomeGenerator = new Random();
            int number = randomeGenerator.Next(1, 100);

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNum = int.Parse(guess);

            int guessCount = 1;

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
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();

            Console.Write("");
        
        } while (playAgain == "yes");
    
    
    }
}