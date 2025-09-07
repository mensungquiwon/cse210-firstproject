using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = promptUserName();
        int numeric = promptUserNumber();

        int square = squareNumber(numeric);
        DisplayResult(name, square);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void  DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is: {square}");
    }


}