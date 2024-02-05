using System;

class Program
{
    static void Main(string[] arg)
    {
        //creating a new instance of the reference class without an end verse or endVerse=0
        Reference reference = new Reference("John", 3, 16);
        string text ="For God so love the world. That he gave his only begotten son. That who so ever believes in Him shall not perish but have everlasting life.";
        
        //creating a new instance of the scripture class, which will display the full refernce and text of the scripture.
        Scripture scripture =  new Scripture(reference.DisplayReference(), text);
   

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
