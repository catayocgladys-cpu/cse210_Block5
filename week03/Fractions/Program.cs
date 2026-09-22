//Week 3 Encapsulation Learning Activity
//This is for fractions and will be used to demonstrate encapsulation in C#.
//Gladys Catayoc

using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a fraction using the first constructor
        //This should create 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        //Create a fraction using the second constructor
        //This should create 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        //Create a fraction using the third constructor
        //This should create 3/4
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        //Test the setters
        //Change the fraction to 1/3
        fraction3.SetTop(1);
        fraction3.SetBottom(3);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

    }
}