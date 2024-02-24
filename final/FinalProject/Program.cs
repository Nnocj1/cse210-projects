using System;
/* Author: Nicholas Oblitey Commey
Purpose: CSE210 Final Project
Program Purpose: This Program is to replicate the school administration system. It may be applied to 
other organizations. 
Program Inspiration: In Ghana, most schools run a paper based system which can be tedious, waste time as
well as not reaching full potential. What if teachers can keep a digital lesson note which is easier to 
maintain, or a system where calculations for student reports are automatically generated?.. We begin to see the benefits.

Program Function: This program is to demonstrate some of the conditional logics that could exist in the 
Software Application of a school.*/

class Program
{
    static void Main(string[] arg)
    {
        
        {
            
            List<Person> persons = new List<Person>();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<NonTeachingStaff> nonTeachingStaff = new List<NonTeachingStaff>();
            SchoolManager schoolManager = new SchoolManager(persons,students,teachers,nonTeachingStaff);

            schoolManager.Start();
            
        
        }
    }    
}