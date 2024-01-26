using System;
using System.IO;
using System.Collections.Generic;

/* Author: Nicholas Oblitey Commey
   Purpose: W02- Assignment -Abstraction
   Date Completed: 01/26/2024 */


class Program
{
    static void Main(string[] arg)
    {   
       
        Console.WriteLine("Welcome to the Journal Program");
        
        Journal myJournal = new Journal();
        
        while (true)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Files names\n6.Quit");
            Console.Write("What is your choice?: ");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);

            if (choice == 1) 
            
            {
               string[] prompts = {
                "Are you excited today?: ",
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
              myJournal.AddEntry(newEntry);
            } 

            else if (choice == 2)
            {  
                //Display the entries in the journal.
                myJournal.DisplayEntry();
            }

            // Here I show creativity. Knowing that some users may forget the name of the file,
            // I have designed it to show all the files saved in the directory.
            else if (choice == 3)
            {   
                //Load saved entries from named file
                myJournal.LoadFromFile();
                
                 
            }

            else if (choice == 4)
            { 
                //Save entries into a file
                myJournal.SaveFile();

            }

            else if (choice == 5)
            {   
                // Here I show creativity and exceed the requirement. Knowing that some users may forget the name of the file,
                // I have designed it to show all the files saved in the directory.
                myJournal.DisplayAllFilenames();
            }

            else if (choice == 6)
            {
               break;
            }
        }
       
    }  

}
