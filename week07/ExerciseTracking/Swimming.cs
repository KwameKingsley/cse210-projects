using System;

class Swimming : Activity
{
    private int _laps;
    private const double LapLength = 50.0; // meters

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * LapLength) / 1000; // Convert meters to km
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}
