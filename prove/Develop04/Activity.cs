using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private int _duration;
    private string _description;

    public Activity(string name , string activityInfo) // This is also for setting the activity length's value.
    {
        _description = activityInfo;
        _name = name;
   
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}\n");
        Console.WriteLine(_description);
        Console.WriteLine("How long in seconds will you like for your session?");
        string userDuration = Console.ReadLine();
        int duration = int.Parse(userDuration);

        SetDuration(duration);
        
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Thread.Sleep(1000);
    }
    

    public void DisplayEndingMessage()
    {   
        ShowSpinner(3);
        Console.WriteLine($"\nWell done! You have completed the {_name} in {_duration} seconds.\n");
    }

    public void ShowSpinner(int seconds)
    {
        Stopwatch newStopwatch = Stopwatch.StartNew();

        while (newStopwatch.Elapsed.TotalSeconds < seconds )
        {
            string[] prompts ={"|","/","-","\\"};
            foreach (string p in prompts)
            {
                if ( newStopwatch.Elapsed.TotalSeconds < seconds)//Without this check, it will over spin
                {
                    Console.Write(p);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                //Console.WriteLine("\n");
            }
        }  
    }

    public void ShowCountDown(int seconds)
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Stopwatch newStopwatch = Stopwatch.StartNew();

        while (newStopwatch.Elapsed.TotalSeconds < seconds && (DateTime.Now < endTime))
        
        {
            for (int i= seconds; i > 0; i--)
            {
                if (newStopwatch.Elapsed.TotalSeconds < seconds)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    if (DateTime.Now >= endTime)
                    {
                        break;
                    }

                }
            }   
        }
        Console.WriteLine("");
    }

}