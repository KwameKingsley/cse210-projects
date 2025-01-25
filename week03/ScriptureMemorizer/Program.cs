using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Matthew", 11, 28), "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
            new Scripture(new Reference("2 Nephi", 25, 26), "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."),
            new Scripture(new Reference("Alma", 32, 23), "And now, he imparteth his word by angels unto men, yea, not only men but women also. Now this is not all; little children do have words given unto them many times, which confound the wise and the learned."),
            new Scripture(new Reference("Doctrine and Covenant", 31, 13), "Be faithful unto the end, and lo, I am with you. These words are not of man nor of men, but of me, even Jesus Christ, your Redeemer, by the will of the Father. Amen.")
        };

        // Randomly select a scripture
        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
                break;

            if (!scripture.HideRandomWords())
                break; // End when all words are hidden
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Program has ended.");
    }
}