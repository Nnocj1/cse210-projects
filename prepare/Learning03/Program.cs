/*Author: Nicholas Oblitey Commey
Principles to learn: Encapsulation.
Date: 2/2/2024*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frt1 = new Fraction();
        //Display a string type of a default fraction without passing in parameters.
        Console.WriteLine(frt1.GetStringFraction());
        //Display a decimal type of default fraction without passing in parameters.
        Console.WriteLine(frt1.GetDecimalFraction());


        Fraction frt2 = new Fraction(5);
        //Display a string type of a fraction that accepts only one parameter.
        Console.WriteLine(frt2.GetStringFraction());
        //Display a decimal type of a fraction that accepts only one parameter.
        Console.WriteLine(frt2.GetDecimalFraction());


        Fraction frt3 = new Fraction(3, 4);
        //Display a string type of a fraction that accepts two parameters. The first for top, and second for bottom.
        Console.WriteLine(frt3.GetStringFraction());
        //Display a decimal type of a fraction that accepts two parameters. The first for top, and second for bottom.
        Console.WriteLine(frt3.GetDecimalFraction());


        Fraction frt4 = new Fraction(1, 3); // Accepting two parameters. This time with different values.
        //Display a string type of a fraction that accepts two parameters. The first for top, and second for bottom.
        Console.WriteLine(frt4.GetStringFraction());
        //Display a decimal type of a fraction that accepts two parameters. The first for top, and second for bottom.
        Console.WriteLine(frt4.GetDecimalFraction());
    }
}
