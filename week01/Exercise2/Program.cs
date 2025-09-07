using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your test score? ");
        string gradePercentage = Console.ReadLine();
        int userInput = int.Parse(gradePercentage);

        string letter = "";


        if (userInput >= 90 && userInput <= 100)
        {
            letter = "A";
        }
        else if (userInput >= 80)
        {
            letter = "B";
        }
        else if (userInput >= 70)
        {
            letter = "C";
        }
        else if (userInput >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You received a {letter}.");
        {
            if (userInput >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
        }

        
    }
}