using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        do
        {
            Random randomGenerator = new Random();
            int userInput = randomGenerator.Next(1, 101);
            int guessCount = 0;
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine();
            Console.WriteLine("I'm expecting a number between 1 and 100.");

            int guess = -1;
            while (true)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;
                if (guess < userInput)

                {
                    Console.WriteLine("Lower.");
                }
                else if (guess > userInput)
                {
                    Console.WriteLine("Higher.");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Game over. You guessed it {guessCount} times ");
                    break;
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");
        Console.WriteLine("Game over. Thanks for playing!");
    }    
    
}