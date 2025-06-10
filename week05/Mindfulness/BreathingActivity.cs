using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through slow breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            elapsed += 4;
            if (elapsed >= _duration)
            {
                break;
            }
            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            elapsed += 6;
        }
        DisplayEndingMessage();
    }
}