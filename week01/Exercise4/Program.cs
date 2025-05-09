using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Type the number that you would like to add to the list type 0 when finished: ");
            string input = Console.ReadLine();
            int to_add = Int32.Parse(input);

            if (to_add == 0)
            {
                int sum = numbers.Sum();
                Console.WriteLine($"Sum: {sum}");
                int max = numbers.Max();
                int min = numbers.Min();
                double average = numbers.Average();
                Console.WriteLine($"Average: {average}");
                Console.WriteLine($"Highest: {max}");
                Console.WriteLine($"Lowest: {min}");
                List<int> sorted = numbers.OrderBy(n => n).ToList();
                Console.WriteLine("Sorted: ");
                foreach (int n in sorted)
                {
                    Console.WriteLine(n);
                }
                return;
            }
            else
            {
                numbers.Add(to_add);
            }
        }
        
    }
}