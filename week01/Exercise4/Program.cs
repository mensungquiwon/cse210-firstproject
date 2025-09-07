using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // please note we could use a do-while loop here instead
        int numeric = -1;
        while (numeric != 0)
        {
            Console.Write("Enter a number (type 0 to quit): ");
            string userInput = Console.ReadLine();
            numeric = int.Parse(userInput);


            // Only add the number to the list if it is not 0
            if (numeric != 0)
            {
                numbers.Add(numeric);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        // part 2: compute the average 
        // Notice that we first cast the sum variable to be a float. Otherwise, because
        // both the sum and the count are integers, the computer will do integer division
        // and I will not get a decimal value (even though ut result into a float variable).

        // By making one of the variables a float, the computer knows that it has to 
        // do the floating point division, and we get the decimal value that we expect.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // part 3: find the max
        // There are several ways to do this, such as sorting the list

        numbers.Sort();;
        int min = numbers[0];
        int max = numbers[numbers.Count - 1];
        {
            Console.WriteLine($"The max is: {max}");
            Console.WriteLine($"The min is: {min}");
        }
        Console.WriteLine("The sorted numbers in the list are:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        







    }
}
    