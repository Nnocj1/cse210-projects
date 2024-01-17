/*Name: CSE210 Learn- Loops and other functions
  Author: Nicholas Oblitey Commey
  Date: 17/01/2024*/

using System;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();
        int newNumber = -1;

        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {   
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            newNumber = int.Parse(number);
            

            if (newNumber != 0)
            {
                numbers.Add(newNumber);


                //find the smallest number
                if (newNumber > 0)
                {
                    positiveNumbers.Add(newNumber);
                }
                
            }
            
        }
        //Sum of list
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is : {total}");
             
            
        //List Average
        double average = numbers.Average();
        Console.WriteLine($"The average is {average}");



        //max list
        int max = numbers[0];
        foreach ( int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The highest number is {max}");
  


        //min positive list
        int min = positiveNumbers[0];
        foreach ( int number in positiveNumbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console. WriteLine($"The smallest positive number is {min}");


        //Sorted list
        Console.WriteLine($"The sorted list: ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        

    }
}