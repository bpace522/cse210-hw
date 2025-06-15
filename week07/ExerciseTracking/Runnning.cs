using System;

public class Running : Activity
{
    private decimal _distance;

    public Running(decimal distance, int minutes) : base(minutes)
    {
        _distance = distance;
    }

    public decimal getPace()
    {
        return _minutes / _distance;
    }

    public decimal getSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override string getSummary()
    {
        return $"{getDate()} Running ({_minutes})- Distance {_distance} miles, Speed {Math.Round(getSpeed(), 1)}, Pace: {getPace()} min per mile";
    }
}