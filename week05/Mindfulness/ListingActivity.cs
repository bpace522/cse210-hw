using System;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You may begin listing in: ");
        ShowCountDown(5);

        List<string> items = new();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
                items.Add("x");
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
}