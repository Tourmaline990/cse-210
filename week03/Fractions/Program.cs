using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction number = new Fraction();
        Console.Write(">");
        Console.WriteLine(number.GetFractionString());
        Console.WriteLine(number.GetFractionDecimal());

        
        Fraction number1 = new Fraction(5);
        Console.Write("> ");
        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetFractionDecimal());

        Fraction number2 = new Fraction(8,3);
        Console.Write(">");
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetFractionDecimal());

        Fraction number3 = new Fraction(3,4);
        Console.Write(">");
        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetFractionDecimal());

        Fraction number4 = new Fraction(1,3);
        Console.Write(">");
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetFractionDecimal());
    }
}