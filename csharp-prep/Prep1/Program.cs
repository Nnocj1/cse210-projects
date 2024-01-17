using System;

Console.WriteLine("Hello Prep1 World!");

//Prompt user for first and last name
Console.WriteLine("What is your first name?: ");
string fname = Console.ReadLine();
Console.WriteLine("What is your last name?: ");
string lname = Console.ReadLine();

Console.WriteLine($"{lname}, {fname} {lname}");
