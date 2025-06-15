using System;

public abstract class Activity
{
    protected int _minutes;

    public Activity(int minutes)
    {
        _minutes = minutes;
    }

    public string getDate()
    {
        return DateTime.Today.ToString("dd MMM yyyy");
    }
    public abstract string getSummary();
}