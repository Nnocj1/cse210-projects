using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Diagnostics.CodeAnalysis;


class Journal
{
    // initializing the new entry lists
    public List<Entry>_entries = new List<Entry>();


    //Add the entry to the journal.
    public void AddEntry(Entry  entry)
    {
        _entries.Add(entry);
    }
    

    //Display all entries. Either those simply added to the _entries list or those stored in a file.
    public void DisplayEntry()
    {
        //looping through each entry in the _entries list to display
        foreach (Entry entry in _entries)
        {
            entry.Display();
       
        }
    }

    public  void SaveFile()
    {  

        //Prompt user to name the file in which those entries will be saved
        Console.WriteLine("What name will you give to your file?: ");
        string filename = Console.ReadLine();

        //To Store entries in a file the user names
        using (StreamWriter outputFile = new StreamWriter(filename))

        //To take each of the component or variables needed to construct the entry
        {
         foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._currentDate}|{entry._randomPrompt}|{entry._userResponds}");
            }
        }
        //closed the streamwriter to ensure that changes are saved.
        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile()
    {
        //Prompt the user to type in the name of an existing file, to load it content. 
        //This will make the file available to display it's content
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();


        // if the name of the file matches and existing file, it load the file.
        if (File.Exists(filename))
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    // Read a line and split it using the delimiter
                    string[] entryFields = reader.ReadLine().Split('|');

                    if (entryFields.Length == 3)
                    {
                        string currentDate = entryFields[0];
                        string randomPrompt = entryFields[1];
                        string userResponds = entryFields[2];

                        /*I wrote this section ONLY to express my understanding. I hope this will help me learn
                         1. Because of the phrase 'new Entry', This section below goes into the entry.cs or Entry class to supply it with the component value
                         of each of the entry in the file, namely _currentDate, _randomDate, and _userResponds. 
                         2. The Entry class  fills those values into it's template ready to be displayed as complete entries.
                         3. Beacuse this section is using the '_entries.Add' function, those entries are added to the _entries list, loaded to be displayed.
                         4. When the user selects 'Display', the DisplayEntry method loops through the _entries to display each of the entry saved.*/

                        _entries.Add(new Entry
                        {
                            _currentDate = currentDate,
                            _randomPrompt = randomPrompt,
                            _userResponds = userResponds
                        });
                    }    
                }
            }
            //After loading the file, it prompt the user that the file has been loaded.
            Console.WriteLine($"Journal loaded from {filename}\n");
        }
        else
        //Incase the file the user wants to load does not exist, it displays this prompt rather than throwing an error.
        {
            Console.WriteLine($"File {filename} not found.\n");
        }
    }

}