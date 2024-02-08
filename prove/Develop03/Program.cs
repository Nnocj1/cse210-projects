using System;

class Program
{
    static void cain(string[] arg)
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
        Scripture scripture =  new Scripture(reference.DisplayReference(), userText);
   

        //while the scripture is not completely hidden, and the user press enter instead of quiting, it should hide random words.
        while (!scripture.IsCompletelyHiddden())
        {
           // Console.Clear();
            //Display the full scripture
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }

            else
            {
                scripture.HideRandomWords();
            }

        }
    }
}
