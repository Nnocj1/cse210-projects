/*Author: Nicholas Oblitey Commey
Purpose: To prove inheritance skills
Date: 17/2/2024
Lessons: There are two ways to write a string list.*/

using System;

class Program
{

    static void Main(string[] args)
    {
        int numberofActivitiesDone = 0;
        string tyOrIes = " ";

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity"); 
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);

            //Here is where I show creativity by ensuring that at the end of each program,
            // the user see the number of activities completed. 
            

            
            if (numberofActivitiesDone >= 2)
            {
                tyOrIes = "activities";
            }

            else if  (numberofActivitiesDone <= 1)
            {
                tyOrIes = "activity";
            }


            if (choice == 1)
            {
               string name = "Breathing Activity";
               string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

               BreathingActivity newBreathingActivity = new BreathingActivity(name, description);
               newBreathingActivity.Run();

               numberofActivitiesDone += 1;

            }

            else if (choice == 2)
            {
               string name = "Reflecting Activity";
               string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

               //This section is the runing of the Reflecting Activity
               ReflectingActivity newReflectingActivity = new ReflectingActivity(name, description);
               newReflectingActivity.Run();

               numberofActivitiesDone += 1;
            }

            else if (choice == 3)
            {
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                //This section is the runing of the Listing Activity
               ListingActivity newListingActivity = new ListingActivity(name, description);
               newListingActivity.Run(); 

               numberofActivitiesDone += 1;
            }

            else if (choice == 4)
            {
                break;
            }   
            
            Console.WriteLine($"You have completed {numberofActivitiesDone} {tyOrIes}!");
        }
    }
}