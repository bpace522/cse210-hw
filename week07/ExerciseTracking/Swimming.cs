using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int minutes) : base(minutes)
    {
        _laps = laps;
    }

    public decimal getDistance()
    {
        return _laps * 50 / 1000 * 0.62m;
    }

    public decimal getSpeed()
    {
        return getDistance() / _minutes * 60;
    }

    public decimal getPace()
    {
        return _minutes / getDistance();
    }

    public override string getSummary()
    {
        return $"{getDate()} Swimming ({_minutes})- Distance {getDistance()} miles ({_laps} laps), Speed {Math.Round(getSpeed(), 1)}, Pace: {Math.Round(getPace(), 1)} min per mile";
    }
}