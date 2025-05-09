using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int number_squared = SquareNumber(Number);
        DisplayResult(Name, number_squared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = Int32.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}