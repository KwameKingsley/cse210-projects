using System;
using System.Collections.Generic;

abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name}");
        Console.WriteLine(Description);
        Console.Write("\nEnter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine($"Duration: {Duration} seconds");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % 4] + "\b \b");
            Thread.Sleep(250);
            i++;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...\b \b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
