using System;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
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
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(2);
            Console.Write("> ");
            if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
                items.Add("x");
        }

        DisplayEndingMessage();

    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];

    private string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];
}