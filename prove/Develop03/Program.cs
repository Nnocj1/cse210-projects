/*Author: Nicholas Oblitey Commey
Purpose: Week 3 -CSE210 Assignment.
Exceeding requirements- In this program, i exceed the requirement and show creativity by applying
or adding the previous week's lessons to make it more user friendly. Such that, users can enter their 
own scripture, add them to a new or an existing file, load it, and memorize them.*/


using System;

class Program
{
    static void Main(string[] arg)
    {

        Console.WriteLine("Welcome to the Memorizer King");
        
        ScriptureBank scriptureBank = new ScriptureBank();
        
        while (true)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Enter new Scripture \n2.Load scriptures\n3.Save scripture\n4.Files\n5.Memorize scripture\n6.Quit");
            Console.Write("What is your choice?: ");
            string userChoice = Console.ReadLine();
            nt choice = int.Parse(userChoice);

            if (choice == 1) 
            {
                Console.Write("What is the name of the scripture?");
                string scriptureName = Console.ReadLine();

                Console.Write("What is the scripture's chapter?");
                string userChapter = Console.ReadLine();
                int scriptureChapter = int.Parse(userChapter);

                Console.Write("What is the scripture's start verse?");
                string userVerse = Console.ReadLine();
                int scriptureVerse = int.Parse(userVerse);

                Console.Write("What is the scripture end verse?");
                string userEndVerse = Console.ReadLine();
                int scriptureEndVerse = int.Parse(userEndVerse);
            

                Console.Write("Enter the scripture text");
                string userText = Console.ReadLine();

                Reference reference = new Reference(scriptureName, scriptureChapter, scriptureVerse, scriptureEndVerse);
                
                
                //creating a new instance of the scripture class, which will display the full refernce and text of the scripture.
                Scripture newScripture =  new Scripture(reference.DisplayReference(), userText);
        
               
                scriptureBank.AddScripture(newScripture);

            }
        

            else if (choice == 2)
            {
                scriptureBank.LoadFromFile();
            }

            else if (choice == 3)
            {
                scriptureBank.SaveFile();
            }

            else if (choice == 4)
            {
                scriptureBank.DisplayAllFilenames();
            }

            else if (choice == 5)
            {
                scriptureBank.MemorizeScripture();
            }

            else if (choice == 6)
            {
                break;
            }
        }

    }
}
