using System;

class ReflectingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity",
        "This activity helps you reflect on times when you have shown strength and resilience, recognizing the power you have.") { }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\n{Prompts[rand.Next(Prompts.Length)]}");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(Questions[rand.Next(Questions.Length)]);
            ShowSpinner(5);
        }

        End();
    }
}
