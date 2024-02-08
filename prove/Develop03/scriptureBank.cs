using System;
using System.IO;
using System.Collections.Generic;

class ScriptureBank
{
    // initializing the new entry lists
    public List<Scripture> _scriptures = new List<Scripture>();

    //Add the Scripture to the ScriptureBank.
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    //Display all scriptures. Either those simply added to the _scriptures.
    public void DisplayScripture()
    {
        //looping through each entry in the _entries list to display
        foreach (Scripture scripture in _scriptures)
        {
            scripture.Display();

        }
    }

    public void SaveFile()
    {
        //Prompt user to name the file in which those entries will be saved
        Console.WriteLine("What name will you give to your file?: ");
        string fileName = Console.ReadLine();

        //To Store entries in a file the user names
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //To take each of the component or variables needed to construct the entry
            foreach (var scripture in _scriptures)
            {
                outputFile.WriteLine($"{scripture.Display()}|");
            }
        }
        //closed the streamwriter to ensure that changes are saved.
        Console.WriteLine($"Journal saved to {fileName}\n");
    }

    public void LoadFromFile()
    {
        // Here I show creativity. Knowing that some users may forget the name of the file,
        // I have designed it to show all the files saved in the directory.
        DisplayAllFilenames();

        //Prompt the user to type in the name of an existing file, to load it content. 
        //This will make the file available to display it's content
        Console.Write("\nEnter the filename to load: ");
        string fileName = Console.ReadLine();

        // if the name of the file matches and existing file, it load the file.
        if (File.Exists(fileName))
        {
            _scriptures.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Assuming each line in the file represents a scripture entry
                    // You might need to adjust this part based on how your Scripture class is structured
                    // Assuming the line format is "Book Chapter:Verse - Text"
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string reference = parts[0].Trim();
                        string text = parts[1].Trim();
                        // Assuming your Scripture class has a constructor that takes reference and text
                        Scripture scripture = new Scripture(reference, text);
                        _scriptures.Add(scripture);
                        Console.Write("Contains characters.");
                    }
                }
            }
            //After loading the file, it prompt the user that the file has been loaded.
            Console.WriteLine($"Journal loaded from {fileName}\n");
        }
        else
        //Incase the file the user wants to load does not exist, it displays this prompt rather than throwing an error.
        {
            Console.WriteLine($"File {fileName} not found.\n");
        }
    }


    // Here I show creativity. Knowing that some users may forget the name of the file,
    // I have designed it to show all the files saved in the directory.
    public void DisplayAllFilenames()
    {
        Console.WriteLine("\nBelow are all the files in the current directory:\n");
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }

    public void MemorizeScripture()
    {

        foreach (Scripture scripture in _scriptures)
        {
            //while the scripture is not completely hidden, and the user press enter instead of quiting, it should hide random words.
            while (!scripture.IsCompletelyHiddden())
            {
                // Console.Clear();
                //Display the full scripture
                Console.WriteLine(scripture.Display());
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
}
