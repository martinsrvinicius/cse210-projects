using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine($"What is the magic number? {magicNumber} ");
        int guess = 0;
        string input;
        //Strech requirement: counting guesses
        int count = 0;
        do 
        {
        count ++;
        Console.Write("What is your guess? ");
        input = Console.ReadLine();

        if (input != null)
        {
            guess = int.Parse(input);
        }

        if(guess < magicNumber) 
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else 
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You took {count} guesses!");
        }
        } while (magicNumber != guess);

    }
}