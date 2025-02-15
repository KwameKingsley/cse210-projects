using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _streak;
    private DateTime _lastRecordedDate;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _streak = 0;
        _lastRecordedDate = DateTime.MinValue;
    }

    // Public getters
    public int Score => _score;
    public int Level => _level;
    public int Streak => _streak;
    public DateTime LastRecordedDate => _lastRecordedDate;

    public List<Goal> GetGoals() => _goals;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count) return;

        _goals[index].RecordEvent(ref _score);

        // Update daily streak
        if (_lastRecordedDate.Date == DateTime.Today.AddDays(-1))
            _streak++;
        else if (_lastRecordedDate.Date != DateTime.Today)
            _streak = 1;

        _lastRecordedDate = DateTime.Today;

        // Check for leveling up
        if (_score >= _level * 1000)
            _level++;
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
}