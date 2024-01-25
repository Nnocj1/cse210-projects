using System;


public class Journal
{
    public string _entry;
    public List<Entry>_entries = new List<Entry>();// initializing the new entry lists.

    //get and return entries.


    public void AddEntry(Entry  entry)
    {
        _entries.Add(entry);
    }
    

    //displaying the journal with the entries
    public void Display()
    {
        //looping through each entry in the joural to display
        foreach (Entry entry in _entries)
        {
            entry.Display();
       
        }
    }


}