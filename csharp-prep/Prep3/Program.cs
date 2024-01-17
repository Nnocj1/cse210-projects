/* Name: An Assignment to practice on Loops in C#
   Date: 17/01/2024
   Author: Nicholas Oblitey Commey*/


using System;

Console.WriteLine("Hello Prep3 World!");

string playAgain = "yes";


//Ensure that each instance to try again, it starts counting afresh
while (playAgain == "yes")
{
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 100);

    int guessNumber = -1;
    int count = 0;


    Console.WriteLine("There is a hidden number. Guess what that number is");

    //Keep asking for a guess till the answer matches the magic one.
    while (magicNumber != guessNumber)
    {
        Console.Write("What is your guess?: ");
        string Number = Console.ReadLine();
        guessNumber = int.Parse(Number);


        if (magicNumber == guessNumber)
        {
            Console.WriteLine("You are right!");
        }

        else if (magicNumber > guessNumber)
        {
            Console.WriteLine("Move higher");
        }

        else
        {
            Console.WriteLine("Move lower");
        }

        count++;

    }

    Console.WriteLine($"You tried {count} times.");

    Console.WriteLine("Would you like to play again? yes/no:");
    string pAgain = Console.ReadLine();
    playAgain = pAgain.ToLower();



}
