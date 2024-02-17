using System;

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
        string[] prompts ={"|","/","-","\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (startTime < endTime)
        {
            foreach (string p in prompts)
            {
                Console.Write(p);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");
        }
    }

    public void ShowCountDown(int seconds)
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (startTime < endTime)
        {
            for (int i=5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            Console.WriteLine("");
        }
    }
}