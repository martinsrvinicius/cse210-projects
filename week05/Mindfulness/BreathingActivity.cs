using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4); 
            if (DateTime.Now >= endTime) break;
            Console.Write("Breathe out... ");
            ShowCountDown(6); 
        }

        DisplayEndingMessage();
    }
}