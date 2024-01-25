using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] arg)
    {   
       
        Console.WriteLine("Welcome to the Journal Program");
        
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What is your choice?: ");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);

            if (choice == 1)
            {
              string[] prompts = {
                "I'm I excited today?: ",
                "Who was the most interesting person I interacted with today?: ",
                "What was the best part of my day?: ",
                "How did I see the hand of the Lord in my life today?: ",
                "What was the strongest emotion I felt today?: "
              };
              
              //a random object for generating random prompts
              Random random = new Random();

              int randomIndex = random.Next(prompts.Length);
              string randomPrompt = prompts[randomIndex];

              //display a random prompt for the user to enter details
              Console.Write(randomPrompt);
              string userResponds = Console.ReadLine();

              //create an entry, get time, and append the responds to the entry
              Entry newEntry = new Entry(); 
              DateTime currentDate =  DateTime.Now;
              string dateText = currentDate.ToShortDateString();

              //attaching the properties of the entry's object
              newEntry._currentDate = dateText;
              newEntry._randomPrompt = randomPrompt;
              newEntry._userResponds = userResponds;
              
              //Adding the entries to the journal
        
              journal.AddEntry(newEntry);

              //attaching the properties of the 
            } 

            else if (choice == 2)
            {  
                //Display the items in the journal.
                journal.Display();
            }

            else if (choice == 3)
            {
                Console.Write("Name the file");
                string fileName =  Console.ReadLine();
                 
            }

            else if (choice == 4)
            {
                Console.WriteLine("What is the file name?: ");
                string fileName = Console.ReadLine();
                

            }

            else if (choice == 5)
            {
               break;
            }
        }
       
    }  

}
