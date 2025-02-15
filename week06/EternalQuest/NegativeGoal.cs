using System;

class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(ref int score)
    {
        score -= _points; // Deduct points instead of adding
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"{_shortName} [⚠] - {_description}";

    public override string GetStringRepresentation() => $"NegativeGoal:{_shortName},{_description},{_points}";
}