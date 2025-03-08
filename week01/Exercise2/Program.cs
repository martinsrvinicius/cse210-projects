using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        int gradePercent = int.Parse(Console.ReadLine());
        string letter;
        if (gradePercent < 60)
        {
            letter = "F";
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (gradePercent <= 70) 
        {
            letter = "D";
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (gradePercent <= 80) 
        {
            letter = "C";
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (gradePercent <= 90)
        {
            letter = "B";
            Console.WriteLine($"Your grade is {letter}");
        }
        else {
            letter = "A";
            Console.WriteLine($"Your grade is {letter}");
        }

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else {
            Console.WriteLine("I am sorry, you didn't passed! You need to reach at least C grade");
        }
    }
}