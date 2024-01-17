//A program that determines the letter grade for a course.
/*Name: Nicholas Oblitey Commey
  Date: 15/01/2024*/
using System;

Console.WriteLine("Hello Prep2 World!");



Console.Write("Enter your percentage score on any subject to see your grade: ");
string percentScore = Console.ReadLine();
int score = int.Parse(percentScore);
string sign;
string grade;

if (score % 10 >= 7)
{
    if (score >= 97)
    {
        sign = "";
    }
    else
    {
        sign = "+";
    }
}

else if (score % 10 < 3)
{
    sign = "-";
}

else
{
    sign = "";
}


if (score >= 90)
{
    grade = "A";
    Console.WriteLine($"Your grade is {grade}{sign}");
}

else if (score >= 80)
{
    grade = "B";
    Console.WriteLine($"Your grade is {grade}{sign}");
}

else if (score >= 70)
{
    grade = "c";
    Console.WriteLine($"Your grade is {grade}{sign}");
}

else if (score >= 60)
{
    grade = "D";
    Console.WriteLine($"Your grade is {grade}{sign}");
}

else
{
    grade = "F";
    Console.WriteLine($"Your grade is {grade}{sign}");
}

if (score >= 70)
{
    Console.WriteLine("Congratulations you passed!");
}
else
{
    Console.WriteLine("You did not pass the test. There is more room for improvement");
}
