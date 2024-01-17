using System;


class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int newNumber = PromptUserNumber();
        int squareNumber = SquareNumber(newNumber);

        DisplayResult(userName, squareNumber);

    }


    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() 
    {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();

    return name;
    }

    static int PromptUserNumber()
    {
    Console.Write("Please enter your favorite number:");
    string number = Console.ReadLine();
    int newNumber = int.Parse(number);
    
    return newNumber;
    }

    static int SquareNumber(int newNumber) 
    { 

        int numberSquare = newNumber * newNumber;

        return numberSquare;
    }

    static void DisplayResult(string name, int numberSquare)
    { 

    Console.WriteLine($"Brother {name}, The sqaure of your number is {numberSquare}.");

    }

}



