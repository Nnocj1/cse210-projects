using System;

public class Entry
{
    //stating all the variables need for the entry class to function.
    public string _currentDate;
    public string _randomPrompt;
    public string _userResponds;


    //store the date and responds as entry. Then display
    public void Display() {
        Console.WriteLine($"{_currentDate} - Prompt: {_randomPrompt}\n{_userResponds}\n");
    }
}