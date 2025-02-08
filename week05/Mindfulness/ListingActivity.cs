using System;

class ListingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity helps you reflect on the good things in your life by having you list as many things as you can.") { }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\n{Prompts[rand.Next(Prompts.Length)]}");
        Console.WriteLine("Get ready to start listing...");
        ShowCountdown(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}
