using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        var Running1 = new Running(5, 30);

        var cycling1 = new Cycling(10, 30);

        var swimming1 = new Swimming(100, 45);

        Console.WriteLine(Running1.getSummary());
        Console.WriteLine(cycling1.getSummary());
        Console.WriteLine(swimming1.getSummary());


    }
}