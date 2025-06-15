using System;

public class Cycling : Activity
{
    private decimal _speed;

    public Cycling(decimal speed, int minutes) : base(minutes)
    {
        _speed = speed;
    }

    public decimal getDistance()
    {
        return _speed * _minutes / 60;
    }

    public decimal getPace()
    {
        return _minutes / getDistance();
    }

    public override string getSummary()
    {
        return $"{getDate()} Cycling ({_minutes})- Distance {getDistance()} miles, Speed {_speed}, Pace: {getPace()} min per mile";
    }
}