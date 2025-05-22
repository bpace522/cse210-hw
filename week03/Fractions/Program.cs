using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.DisplayFractionString());
        Console.WriteLine(fraction1.GetDecimal());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.DisplayFractionString());
        Console.WriteLine(fraction2.GetDecimal());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.DisplayFractionString());
        Console.WriteLine(fraction3.GetDecimal());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.DisplayFractionString());
        Console.WriteLine(fraction4.GetDecimal());
    }


}