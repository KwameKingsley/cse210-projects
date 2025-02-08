using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        End();
    }
}
