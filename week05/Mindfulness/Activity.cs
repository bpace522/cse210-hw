using System;
using System.Security.Principal;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter, in seconds, how long you would like to do the activity: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Loading...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            int length = i.ToString().Length;
            Console.Write(new string('\b', length) + new string(' ', length) + new string('\b', length));
        }
    }
}