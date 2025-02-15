using System;
using System.IO;

class DataHandler
{
    private string _filePath = "goals.txt";

    public void Save(GoalManager manager)
    {
        using (StreamWriter outputFile = new StreamWriter(_filePath))
        {
            outputFile.WriteLine($"{manager.Score},{manager.Level},{manager.Streak},{manager.LastRecordedDate}");
            foreach (Goal goal in manager.GetGoals())
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void Load(GoalManager manager)
    {
        if (!File.Exists(_filePath)) return;

        string[] lines = File.ReadAllLines(_filePath);
        if (lines.Length == 0) return;


        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalParts = lines[i].Split(':');
            string[] details = goalParts[1].Split(',');

            Goal goal = goalParts[0] switch
            {
                "SimpleGoal" => new SimpleGoal(details[0], details[1], int.Parse(details[2])),
                "EternalGoal" => new EternalGoal(details[0], details[1], int.Parse(details[2])),
                "ChecklistGoal" => new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])),
                "NegativeGoal" => new NegativeGoal(details[0], details[1], int.Parse(details[2])),
                _ => null
            };

            if (goal != null) manager.AddGoal(goal);
        }
    }
}