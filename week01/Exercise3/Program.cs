using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to the random number generator game");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            Console.WriteLine(number);

            while (true)
            {
                Console.WriteLine("Guess a number between 1-10: ");
                string guess = Console.ReadLine();
                int guess_int = Int32.Parse(guess);

                if (guess_int < number)
                {
                    Console.WriteLine("higher");
                }
                else if (guess_int > number)
                {
                    Console.WriteLine("lower");
                }
                else
                {
                    Console.WriteLine("You got it!");
                    Console.WriteLine("Would you like to play again? Type 'Y' or 'n' ");
                    string keep_playing = Console.ReadLine();
                    if (keep_playing == "Y" || keep_playing == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }
                }
            }
        }

    }
}