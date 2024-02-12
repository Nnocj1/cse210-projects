/* Author: Nicholas Oblitey Commey
Purpose: Practice the principle of Inheritance.
Lessons: We use the term 'base' when refering to items in one class being introduce to another.
Also ensjure to create a public inteeractable version of an encapsulated class.
Date: 12/2/2024 */

using System;

public class Program
{
    static void Main(String[] arg)
    {   
        //check the functionality of the assignment class
        Assignment assignment = new Assignment("Nicholas", "Entertainmemnt");
        assignment.GetSummary();
        
        //check the functionality of the MathAssignment class.
        MathAssignment mathAssignment = new MathAssignment("Commey", "Maths", "5", "16+20");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        
        //check the functionality of the Writing Assignment class.
        WritingAssignment writingAssignment = new WritingAssignment("Oblitey", "Story Book", "Kwekwu Ananse");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
