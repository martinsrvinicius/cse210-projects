using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        int sum = 0;
        float average = 0;
        int largest = 0;
        int smallest = 100;

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int.TryParse(input, out number);
            Console.WriteLine(number);

            //adding number to list
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);


        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }

            if (n < smallest)
            {
                if (n > 0)
                {
                smallest = n;
                }
            }
        }

        //Print
        sum = numbers.Sum();
        average = (float)numbers.Average();
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largest}");
        if (smallest != 0)
        {
        Console.WriteLine($"Smallest positive number: {smallest}");
        }
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}