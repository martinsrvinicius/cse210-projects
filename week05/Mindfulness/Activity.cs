using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;      
    protected string _description; 
    protected int _duration;     

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void Run();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int cycles = seconds * 4; 

       for(int i=cycles; i > 0; i--)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(350);
            Console.Write("\b \b"); 
        }
        Console.WriteLine(); 
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }
        Console.WriteLine(); 
    }
}